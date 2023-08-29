using BrightIdeasSoftware;
using CheckBoxFilterApp.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CheckBoxFilterApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetCheckBox();
            AddItems();
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
            //fastObjectListView1.UncheckAll();
            //fastObjectListView1.ToggleHeaderCheckBox();
            CheckBox checkbox = new CheckBox();
            checkbox.Checked = false;
        }

        private bool AddItems()
        {
            List<TelemetryDataDTO> dtoList = new List<TelemetryDataDTO>();


            for (int i = 0; i < 10; i = i + 1)
            {
                TelemetryDataDTO dto = new TelemetryDataDTO("App", "Func", "Desc", DateTime.Now);
                dto.Application = String.Format("{0}{1}", dto.Application, i);
                dto.Description = String.Format("Description{1}", dto.Description, i);
                dto.Function = String.Format("Func{0}", i);
                dto.CreateTime = DateTime.Now;
                dtoList.Add(dto);
            }

            Console.WriteLine(dtoList);

            this.fastObjectListView1.AddObjects(dtoList);
            this.objectListView1.AddObjects(dtoList);

            foreach (TelemetryDataDTO dto in dtoList)
            {
                fastObjectListView1.UncheckAll();
            }

            return true;
        }
    }
}
