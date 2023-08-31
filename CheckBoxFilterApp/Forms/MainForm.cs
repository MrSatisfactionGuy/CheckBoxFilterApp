using BrightIdeasSoftware;
using CheckBoxFilterApp.Classes;
using CheckBoxFilterApp.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CheckBoxFilterApp
{
    public partial class MainForm : Form
    {
        private SerialziationController serialziationController;
        private List<TelemetryDataDTO> telemetryEntries;
        private readonly string safePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Persist");

        public MainForm()
        {
            InitializeComponent();
            this.Initialize();
            SetCheckBox();
            this.telemetryEntries = AddItems(this.telemetryEntries);
        }

        private void Initialize()
        {
            this.serialziationController = new SerialziationController();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FastObjectListView checkBoxFOLV = new FastObjectListView();
            for (int i = 0; i < fastObjectListView1.Items.Count; i++)
            {
                checkBoxFOLV.UncheckAll();// = fastObjectListView1.Items[i].Checked = false;
                //if (fastObjectListView1.Items[i].Checked == false) ;
                //fastObjectListView1.CheckIndeterminateObject(fastObjectListView1.Items[i]);
            }
        }

        private void SetCheckBox()
        {
            for (int i = 0; i < fastObjectListView1.Items.Count; i++)
            {
                //fastObjectListView1.CheckHeaderCheckBox();
                fastObjectListView1.ToggleSelectedRowCheckBoxes();
            }

            //fastObjectListView1.UncheckAll();
            //fastObjectListView1.ToggleHeaderCheckBox();

        }

        private List<TelemetryDataDTO> AddItems(List<TelemetryDataDTO> entryList)
        {
            if (entryList is null) entryList = this.serialziationController.ReadFromLocal(this.safePath);
            if (entryList.Count > 9)
            {
                if (LoadOLVs(entryList)) return entryList;
            }

            for (int i = 0; i < 10; i = i + 1)
            {
                string app = String.Format("App{0}", i);
                string func = String.Format("Func{0}", i);
                string desc = String.Format("Desc{0}", i);

                TelemetryDataDTO dto = new TelemetryDataDTO(app, func, desc, DateTime.Now);
                entryList.Add(dto);
            }

            Console.WriteLine(entryList);

            

            foreach (TelemetryDataDTO dto in entryList)
            {
                fastObjectListView1.UncheckAll();
            }

            return entryList;
        }
        private bool LoadOLVs(List<TelemetryDataDTO> listToload)
        {
            this.fastObjectListView1.AddObjects(listToload);
            this.objectListView1.AddObjects(listToload);

            return true;
        }

        //private void fastObjectListView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //= false;
        //}

        private void fastObjectListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (this.fastObjectListView1.SelectedObjects is TelemetryDataDTO dto) dto.Ahhhhhhh = !dto.Ahhhhhhh;
            //{
            //this.fastObjectListView1(e, false);
            //}

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.telemetryEntries = this.serialziationController.ReadFromLocal(this.safePath);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.serialziationController.SerializeLocal(this.telemetryEntries, this.safePath);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            List<TelemetryDataDTO> refreshList = this.telemetryEntries.Select(x => x.Application.Where(/*x.Ahhhhhhh == true*/));

            this.ReloadOLV(refreshList);
        }

        private bool ReloadOLV(List<TelemetryDataDTO> listToRefresh)
        {
            this.fastObjectListView1.Clear();
            this.fastObjectListView1.AddObjects(listToRefresh);

            return true;
        }
    }
}
