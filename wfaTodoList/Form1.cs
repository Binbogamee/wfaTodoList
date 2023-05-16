using SQLite;
using System.Collections.Generic;

namespace wfaTodoList
{
    public partial class Form1 : Form
    {
        private SQLiteConnection db;
        private bool edit = false;
        private List<string> types = new List<string>();
        private List<int> listId = new List<int>();
        private int selectID;
        public Form1()
        {
            InitializeComponent();

            buAdd.Enabled = false;
            buCancel.Enabled = false;
            buSave.Enabled = false;
            buDelete.Enabled = false;

            db = new SQLiteConnection("myDB.db");
            db.CreateTable<Note>();

            tbName.TextChanged += All_TextChanged;
            tbType.TextChanged += All_TextChanged;
            tbText.TextChanged += All_TextChanged;

            buAdd.Click += BuAdd_Click;
            buSave.Click += BuSave_Click;
            buDelete.Click += BuDelete_Click;
            buCancel.Click += BuCancel_Click;

            cbTypes.SelectedIndexChanged += CbTypes_SelectedIndexChanged;
            lvNames.SelectedIndexChanged += LvNames_SelectedIndexChanged;
            

            formUpdate();
        }

        private void LvNames_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lvNames.SelectedItems.Count > 0)
            {
                edit = true;
                selectID = listId[lvNames.SelectedItems[0].Index];

                foreach (var item in db.Table<Note>())
                {
                    if (item.ID == selectID)
                    {
                        tbName.Text = item.Name;
                        tbType.Text = item.Type;
                        tbText.Text = item.Text;
                    }
                }
            }
        }

        private void CbTypes_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lvNames.Items.Clear();
            listId.Clear();
            if (cbTypes.SelectedItem == "All")
            {
                foreach (var item in db.Table<Note>())
                {
                    lvNames.Items.Add(item.Name);
                    listId.Add(item.ID);
                }
            }
            else
            {
                foreach (var item in db.Table<Note>())
                {
                    if (item.Type == cbTypes.SelectedItem.ToString())
                    {
                        lvNames.Items.Add(item.Name);
                        listId.Add(item.ID);
                    }
                }
            }
        }

        private void BuCancel_Click(object? sender, EventArgs e)
        {
            formUpdate();
        }

        private void BuDelete_Click(object? sender, EventArgs e)
        {
            db.Delete(new Note() { ID = selectID });
            formUpdate();
        }

        private void BuSave_Click(object? sender, EventArgs e)
        {
            db.Update(new Note() { ID = selectID, Name = tbName.Text, Type = tbType.Text, Text = tbText.Text });
            formUpdate();
        }

        private void BuAdd_Click(object? sender, EventArgs e)
        {
            db.Insert(new Note() { Name = tbName.Text, Type = tbType.Text, Text = tbText.Text });

            formUpdate();
        }

        private void formUpdate()
        {
            cbTypes.Items.Clear();

            cbTypes.Items.Add("All");
            cbTypes.SelectedIndex = 0;

            lvNames.Items.Clear();
            listId.Clear();
            foreach (var item in db.Table<Note>())
            {
                lvNames.Items.Add(item.Name);
                listId.Add(item.ID);
                if (!types.Contains(item.Type))
                {
                    types.Add(item.Type);
                }
            }

            foreach (var item in types)
            {
                cbTypes.Items.Add(item);
            }

            tbName.Text = "";
            tbType.Text = "";
            tbText.Text = "";

            edit = false;
            buAdd.Enabled = false;
            buCancel.Enabled = false;
            buSave.Enabled = false;
            buDelete.Enabled = false;

            selectID = 0;
        }

        private void All_TextChanged(object? sender, EventArgs e)
        {
            if (tbName.Text != "" && tbType.Text != "")
            {
                if (edit)
                {
                    buSave.Enabled = true;
                    buDelete.Enabled = true;
                } else
                {
                    buAdd.Enabled = true;
                }
                buCancel.Enabled = true;
            } 
            else
            {
                buAdd.Enabled=false;
                buCancel.Enabled=false;
                buSave.Enabled=false;
            }
        }
    }

    internal class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string? Text { get; set; }
    }
}