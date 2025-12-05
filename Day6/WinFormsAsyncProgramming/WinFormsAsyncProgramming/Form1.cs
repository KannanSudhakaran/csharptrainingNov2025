using WinFormsAsyncProgramming.Services;

namespace WinFormsAsyncProgramming
{
    public partial class Form1 : Form
    {
        private PrinterService _printerService;
        public Form1()
        {
            InitializeComponent();
            _printerService = new PrinterService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            _printerService.Print(10);
        }

        private void btnThread_Click(object sender, EventArgs e)
        {

            
            _printerService.PrintViaThread(5);
        }
    }
}
