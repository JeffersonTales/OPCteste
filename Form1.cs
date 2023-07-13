using Opc.UaFx.Client;

namespace OPCteste {
    public partial class Form1 : Form {

        #region Constantes
        private const string opcUrl = "opc.tcp://localhost:62541/";
        private const string tagName = "ns=7;s=Alarms.AnalogSource"; //Teste
        #endregion

        #region Atributos
        private OpcClient Client { get; set; }
        #endregion

        #region Inicializa��o
        public Form1() {
            InitializeComponent();
            this.Conectar();
        }
        #endregion

         #region Fun��es Auxiliares
        private void Conectar() {
            try {
                this.Client = new OpcClient(opcUrl);
                this.Client.Connect();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }
            
        }

        #endregion

        #region Bot�es
        private void btnEscrever_Click(object sender, EventArgs e) {

            this.Conectar();
            this.Client.WriteNode(nodeId:tagName,
                                  value: Convert.ToInt32(this.txtEscrever.Text));
            this.Client.Disconnect();
        }

        private void btnLer_Click(object sender, EventArgs e) {

            this.Conectar();
            var temperature =  this.Client.ReadNode(nodeId: tagName);
            this.txtLer.Text = temperature.ToString();
            this.Client.Disconnect();

        }

        #endregion
    }
}