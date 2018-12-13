using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using Attestation_2.Utils;
using Attestation_2.Task_6._13;


namespace Task_6._13
{
    public partial class MainForm : Form
    {
        List<Type> classes;
        Type _currentClass;
        object _constrclass;
        public MainForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;          
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            int index = comboBox1.SelectedIndex;           
            _currentClass = classes[index];
            MethodInfo[] marr = _currentClass.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            ParameterInfo[] param = _currentClass.GetConstructors()[0].GetParameters();
            object[] ConstrParams;
            if (param.Length == 2)
                ConstrParams = UtilitiesForRandom.CreateRndBus();
            else
                ConstrParams = UtilitiesForRandom.CreateRndTram();
            _constrclass = ReflexyUse.ConstrClass(_currentClass, ConstrParams);
           
            foreach (MethodInfo m in marr)
            {
                comboBox2.Items.Add(m.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void wayBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            
            Assembly assembly=Assembly.LoadFrom(openFileDialog1.FileName);
            classes = new List<Type>();
            classes = ReflexyUse.GetInterfaces(assembly);
            foreach(Type cl in classes)           
                comboBox1.Items.Add(cl.FullName);
                       
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            MethodInfo[] marr = _currentClass.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            MethodInfo method = _currentClass.GetMethod(marr[index].Name);
            object res=method.Invoke(_constrclass, null);
            if (res != null)
                textBox1.Text = res.ToString();
            else            
                textBox1.Lines = ReflexyUse.GetAllProperties(_currentClass,_constrclass);
                       
        }
    }
}
