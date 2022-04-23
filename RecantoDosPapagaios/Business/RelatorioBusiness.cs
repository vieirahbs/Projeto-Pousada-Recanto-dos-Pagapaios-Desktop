using RecantoDosPapagaios.Repository;
using System;
using System.Data;
using System.IO;

namespace RecantoDosPapagaios.Business
{
    public class RelatorioBusiness
    {
        private readonly RelatorioRepository _relatorioRepository;

        public int Tipo { get; set; }

        public RelatorioBusiness()
        {
            _relatorioRepository = new RelatorioRepository();
        }

        public void RelatorioFaturamentoChaleMensal(DateTime dtInicio, DateTime dtFim)
        {
            try
            {
                Tipo = 1;

                var relatorio = _relatorioRepository.RelatorioFaturamentoChaleMensal(dtInicio, dtFim);

                ExportarCSV(relatorio, Tipo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RelatorioPerformanceFuncionarios()
        {
            try
            {
                Tipo = 2;

                var relatorio = _relatorioRepository.RelatorioPerformanceFuncionarios();

                ExportarCSV(relatorio, Tipo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RelatorioVisaoGeralMensal(DateTime dtInicio, DateTime dtFim)
        {
            try
            {
                Tipo = 3;

                var relatorio = _relatorioRepository.RelatorioVisaoGeralMensal(dtInicio, dtFim);

                ExportarCSV(relatorio, Tipo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExportarCSV(DataTable dt, int tipo)
        {
            #region ExportaCSV

            var filePath = @"C:\Relatorios\";

            var existe = System.IO.Directory.Exists(filePath);

            if (!existe)
            {
                System.IO.Directory.CreateDirectory(filePath);
            }

            int count;

            if (tipo == 1)
            {
                filePath = filePath + "RelatorioFaturamentoChaleMensal_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".csv";

                var streamWriter = new StreamWriter(filePath, false);

                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    streamWriter.Write(dt.Columns[c]);

                    if (c < dt.Columns.Count - 1)
                        streamWriter.Write(",");
                }

                streamWriter.Write(streamWriter.NewLine);

                count = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        if (!Convert.IsDBNull(dr[c]))
                        {
                            var value = dr[c].ToString();

                            if (value.Contains(","))
                            {
                                value = String.Format("\"{0}\"", value);

                                streamWriter.Write(value);
                            }
                            else
                            {
                                streamWriter.Write(dr[c].ToString());
                            }
                        }

                        if (c < dt.Columns.Count - 1)
                            streamWriter.Write(",");

                        count++;

                        if (count == 6)
                        {
                            streamWriter.Write(streamWriter.NewLine);
                            count = 0;
                        }
                    }
                }

                streamWriter.Close();
            }
            else
            {
                if (tipo == 2)
                {
                    filePath = filePath + "RelatorioPerformanceFuncionarios_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".csv";

                    var streamWriter = new StreamWriter(filePath, false);

                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        streamWriter.Write(dt.Columns[c]);

                        if (c < dt.Columns.Count - 1)
                            streamWriter.Write(",");
                    }

                    streamWriter.Write(streamWriter.NewLine);

                    count = 0;

                    foreach (DataRow dr in dt.Rows)
                    {
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            if (!Convert.IsDBNull(dr[c]))
                            {
                                var value = dr[c].ToString();

                                if (value.Contains(","))
                                {
                                    value = String.Format("\"{0}\"", value);

                                    streamWriter.Write(value);
                                }
                                else
                                {
                                    streamWriter.Write(dr[c].ToString());
                                }
                            }

                            if (c < dt.Columns.Count - 1)
                                streamWriter.Write(",");

                            count++;

                            if (count == 8)
                            {
                                streamWriter.Write(streamWriter.NewLine);
                                count = 0;
                            }
                        }
                    }

                    streamWriter.Close();
                }
                else
                {
                    filePath = filePath + "RelatorioVisaoGeralMensal_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".csv";

                    var streamWriter = new StreamWriter(filePath, false);

                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        streamWriter.Write(dt.Columns[c]);

                        if (c < dt.Columns.Count - 1)
                            streamWriter.Write(",");
                    }

                    streamWriter.Write(streamWriter.NewLine);

                    count = 0;

                    foreach (DataRow dr in dt.Rows)
                    {
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            if (!Convert.IsDBNull(dr[c]))
                            {
                                var value = dr[c].ToString();

                                if (value.Contains(","))
                                {
                                    value = String.Format("\"{0}\"", value);

                                    streamWriter.Write(value);
                                }
                                else
                                {
                                    streamWriter.Write(dr[c].ToString());
                                }
                            }

                            if (c < dt.Columns.Count - 1)
                                streamWriter.Write(",");

                            count++;

                            if (count == 13)
                            {
                                streamWriter.Write(streamWriter.NewLine);
                                count = 0;
                            }
                        }
                    }

                    streamWriter.Close();
                }
            }

            #endregion ExportaCSV
        }
    }
}
