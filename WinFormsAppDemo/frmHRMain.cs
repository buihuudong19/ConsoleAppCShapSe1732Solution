using WinFormsAppDemo.Entities;
using WinFormsAppDemo.Repository;
namespace WinFormsAppDemo
{
    public partial class frmHRMain : Form
    {
        private IEmpRepository _empRepository;   
        public frmHRMain()
        {
            _empRepository = new EmpRepository();
            InitializeComponent();
        }

        private void frmHRMain_Load(object sender, EventArgs e)
        {
            //goi data
            var data = _empRepository.GetAll();

            Employee emp = new Employee(5, "Ma Van Meo", new DateTime(1987, 12, 11), 1, 12, 350000);

            _empRepository.Add(emp);

        }
    }
}