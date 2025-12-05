using System.Threading.Tasks;
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
            MessageBox.Show("after 10 seconds");
        }

        private void btnThread_Click(object sender, EventArgs e)
        {


            _printerService.PrintViaThread(10);
            MessageBox.Show("btnThread click end");
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            _printerService.PrintViaTask(10);
            MessageBox.Show("btnTask click end");
        }

        private async void btnAwaitable_Click(object sender, EventArgs e)
        {
            await _printerService.PrintViaAwaitableTask(10);
            MessageBox.Show("btnAwaiable click  end,after 10 seconds");
        }

        private async void btnResult_Click(object sender, EventArgs e)
        {
          string result= await  _printerService.PrintViaTaskWithResult(10);
          MessageBox.Show(result +" , after 10 seconds");
        }
    }
}
