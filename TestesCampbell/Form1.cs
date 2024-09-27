using TestesCampbell.Paineis;

namespace TestesCampbell
{
    public partial class Form1 : Form
    {
        public ChamadaService ChamadaService { get; set; }
        public string[] tiposChamada = { "most-recent", "since-time", "since-record", "date-range", "backfill" };
        public string[] formatos = { "json", "html", "xml" };

        public Form1()
        {
            InitializeComponent();

            ChamadaService = new ChamadaService();

            cbTipoChamada.Items.AddRange(tiposChamada);
            cbTipoChamada.SelectedItem = "most-recent";

            cbFormato.Items.AddRange(formatos);
            cbFormato.SelectedItem = "json";

            UserControlMostRecent uc = new UserControlMostRecent();
            panel.Controls.Add(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void bt1_Click(object sender, EventArgs e)
        {
            string formato = cbFormato.Text;
            string tipoChamada = cbTipoChamada.Text;


            string p1 = "";
            string p2 = "";
            string uri = "";

            var control = panel.Controls[0];
            Task<string> resultadoChamada = new Task<string>(() => "Resultado da chamada");

            switch (control)
            {
                case UserControlMostRecent:
                    var ucMostRecent = panel.Controls.OfType<UserControlMostRecent>().FirstOrDefault();

                    p1 = ucMostRecent.P1Value;
                    uri = ucMostRecent.UriValue;

                    resultadoChamada = ChamadaService.RealizarChamada(formato, tipoChamada, p1, uri);

                    break;

                case UserControlSinceTime:
                    var ucSinceTime = panel.Controls.OfType<UserControlSinceTime>().FirstOrDefault();

                    p1 = ucSinceTime.P1Value;
                    uri = ucSinceTime.UriValue;

                    resultadoChamada = ChamadaService.RealizarChamada(formato, tipoChamada, p1, uri);

                    break;

                case UserControlSinceRecord:
                    var ucSinceRecord = panel.Controls.OfType<UserControlSinceRecord>().FirstOrDefault();

                    p1 = ucSinceRecord.P1Value;
                    uri = ucSinceRecord.UriValue;

                    resultadoChamada = ChamadaService.RealizarChamada(formato, tipoChamada, p1, uri);

                    break;

                case UserControlDateRange:
                    var ucDateRange = panel.Controls.OfType<UserControlDateRange>().FirstOrDefault();

                    p1 = ucDateRange.P1Value;
                    p2 = ucDateRange.P2Value;
                    uri = ucDateRange.UriValue;

                    resultadoChamada = ChamadaService.RealizarChamada(formato, tipoChamada, p1, uri, p2);

                    break;

                case UserControlBackfill:
                    var ucBackfill = panel.Controls.OfType<UserControlBackfill>().FirstOrDefault();

                    p1 = ucBackfill.P1Value;
                    uri = ucBackfill.UriValue;

                    resultadoChamada = ChamadaService.RealizarChamada(formato, tipoChamada, p1, uri);

                    break;
            }

            tbResposta.Text = await resultadoChamada;
        }

        private void cbTipoChamada_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTipoChamada.Text)
            {
                case "most-recent":
                    panel.Controls.Clear();

                    UserControlMostRecent ucMostRecent = new UserControlMostRecent();
                    panel.Controls.Add(ucMostRecent);
                    break;

                case "since-time":
                    panel.Controls.Clear();

                    UserControlSinceTime ucSinceTime = new UserControlSinceTime();
                    panel.Controls.Add(ucSinceTime);
                    break;

                case "since-record":
                    panel.Controls.Clear();

                    UserControlSinceRecord ucSinceRecord = new UserControlSinceRecord();
                    panel.Controls.Add(ucSinceRecord);
                    break;

                case "date-range":
                    panel.Controls.Clear();

                    UserControlDateRange ucDateRange = new UserControlDateRange();
                    panel.Controls.Add(ucDateRange);
                    break;

                case "backfill":
                    panel.Controls.Clear();

                    UserControlBackfill ucBackfill = new UserControlBackfill();
                    panel.Controls.Add(ucBackfill);
                    break;
            }
        }
    }
}