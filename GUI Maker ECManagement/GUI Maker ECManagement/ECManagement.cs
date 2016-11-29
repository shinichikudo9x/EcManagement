using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Maker_ECManagement
{
    public partial class ECManagement : Form
    {
        public ECManagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Help.Help.EcManagementForm;
            System.Collections.IList siteList;
            ISessionFactory factory =
            new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();

            using (ISession session = factory.OpenSession())
            {
                ICriteria sc = session.CreateCriteria(typeof(Site));
                siteList = sc.List();
                session.Close();
            }
            factory.Close();
        }
    }
}
