using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Threading;

namespace DocTransClient
{
    public delegate void NewFileRecieved(FileRecievedEventArgs e );
    public class FileRecievedEventArgs
    {
        public string FileName;
        public string FromUser;
        public DateTime RecievedOn;
    }
    public enum IWatcherStatus
    {
        Running,
        Stopped
    }
    public class InboxWatcher
    {
        public event NewFileRecieved NewFileRecieved;
        IWatcherStatus sta;
        public IWatcherStatus Status
        {
            get { return sta; }
        }
        public void Start(string TableName)
        {
            BackgroundWorker w = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            w.DoWork += new DoWorkEventHandler((s1, e1) =>
            {
                //int p = int.MinValue;
                while (sta == IWatcherStatus.Running)
                {
                    if (w.CancellationPending) return;
                    try
                    {
                        SqlConnection cn = new SqlConnection(st.ConStr);
                        cn.Open();
                        //SqlDependency d = new SqlDependency(new SqlCommand("SELECT * FROM " + e1.Argument.ToString(), cn));
                        //d.OnChange += new OnChangeEventHandler((ds, de) =>
                        //{
                        //    w.ReportProgress(p++, de);
                        //});

                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        st.EMsgBox(ex.ToString());
                    }
                    Thread.Sleep(1000);
                }
            });
            w.ProgressChanged += new ProgressChangedEventHandler((s2, e2) =>
            {
                if (NewFileRecieved != null)
                    NewFileRecieved((FileRecievedEventArgs)e2.UserState);
            });
            w.RunWorkerCompleted += new RunWorkerCompletedEventHandler((s3, e3) =>
            {

            });
            w.RunWorkerAsync(TableName);
        }
        public void Stop()
        {
            sta = IWatcherStatus.Stopped;
        }
    }
}
