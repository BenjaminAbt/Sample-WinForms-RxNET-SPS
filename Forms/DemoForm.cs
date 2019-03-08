using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenjaminAbt.Samples.WinFormsSpsRxNet.Services;

namespace BenjaminAbt.Samples.WinFormsSpsRxNet.Forms
{
    public partial class DemoForm : Form
    {
        public DemoForm(ISpsService spsService)
        {
            InitializeComponent();

            AddSubscription = spsService.Message
                .ObserveOn(LogBox)
                .Subscribe(x =>
                {
                    string msg = $"[{x.Timestamp:HH:mm:ss}] - {x.Message}" + Environment.NewLine;
                    LogBox.Text = LogBox.Text.Insert(0, msg);

                });
        }

        public IDisposable AddSubscription { get; set; }
    }
}
