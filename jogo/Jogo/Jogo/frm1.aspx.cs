using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Jogo
{
    public partial class frm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Data mínima
            using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
            {
                String query = "SELECT MIN(data) FROM dbo.jogos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        Label1.Text = ((IDataRecord)result)[0].ToString();
                    }
                }
            }

            // Data máxima
            using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
            {
                String query = "SELECT MAX(data) FROM dbo.jogos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        Label2.Text = ((IDataRecord)result)[0].ToString();
                    }
                }
            }

            // COUNT
            using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
            {
                String query = "SELECT COUNT(*) FROM dbo.jogos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        Label3.Text = "Jogos disputados: " + ((IDataRecord)result)[0].ToString();
                    }
                }
            }

            // SUM
            using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
            {
                String query = "SELECT SUM(pontos) FROM dbo.jogos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        Label4.Text = "Total de pontos marcados na temporada: " + ((IDataRecord)result)[0].ToString();
                    }
                }
            }

            // AVG
            using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
            {
                String query = "SELECT AVG(pontos) FROM dbo.jogos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        if (string.IsNullOrWhiteSpace(((IDataRecord)result)[0].ToString()) == false)
                            Label5.Text = "Média de pontos por jogo: " + ((IDataRecord)result)[0].ToString();
                    }
                }
            }

            // MAX
            using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
            {
                String query = "SELECT MAX(pontos) FROM dbo.jogos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        if (string.IsNullOrWhiteSpace(((IDataRecord)result)[0].ToString()) == false)
                            Label6.Text = "Maior pontuação em um jogo: " + ((IDataRecord)result)[0].ToString();
                    }
                }
            }

            // MIN
            using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
            {
                String query = "SELECT MIN(pontos) FROM dbo.jogos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        if (string.IsNullOrWhiteSpace(((IDataRecord)result)[0].ToString()) == false)
                            Label7.Text = "Menor pontuação em um jogo: " + ((IDataRecord)result)[0].ToString();
                    }
                }
            }

            // trocas de pontos máximos
            using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
            {
                String query = "SELECT pontos FROM dbo.jogos ORDER BY id";
                int i = 999;
                int j = 0;
                int z = 0;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader result = command.ExecuteReader();

                    while (result.Read())
                    {
                        if (j == 0)
                        {
                            j = 1;
                            i = (int)((IDataRecord)result)[0];
                        }
                        if ((int)((IDataRecord)result)[0] > i)
                        {
                            z = z + 1;
                            i = (int)((IDataRecord)result)[0];
                        }

                    }
                }
                string k;
                k = z.ToString();

                Label8.Text = "Quantidade de vezes que bateu o próprio recorde: ";
                Label8.Text = Label8.Text + k;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
            {
                String query = "INSERT INTO dbo.jogos (data,pontos) VALUES (@data, @pontos)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@data", Calendar1.SelectedDate );
                    command.Parameters.AddWithValue("@pontos", TextBox1.Text  );

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                    else
                    {
                        connection.Close();  
                    }
                }
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (RadioButtonList1.SelectedIndex == 2) 
            {
                
                //Data mínima
                using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
                {
                    String query = "SELECT MIN(data) FROM dbo.jogos";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader result = command.ExecuteReader();
                
                        while (result.Read()) 
                        {
                            Label1.Text = ((IDataRecord)result)[0].ToString();
                        }
                    }
                }

                // Data máxima
                using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
                {
                    String query = "SELECT MAX(data) FROM dbo.jogos";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader result = command.ExecuteReader();

                        while (result.Read())
                        {
                            Label2.Text = ((IDataRecord)result)[0].ToString();
                        }
                    }
                }

                // COUNT
                using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
                {
                    String query = "SELECT COUNT(*) FROM dbo.jogos";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader result = command.ExecuteReader();

                        while (result.Read())
                        {
                            Label3.Text = "Jogos disputados: " + ((IDataRecord)result)[0].ToString();
                        }
                    }
                }

                // SUM
                using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
                {
                    String query = "SELECT SUM(pontos) FROM dbo.jogos";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader result = command.ExecuteReader();

                        while (result.Read())
                        {
                            Label4.Text = "Total de pontos marcados na temporada: " + ((IDataRecord)result)[0].ToString();
                        }
                    }
                }

                // AVG
                using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
                {
                    String query = "SELECT AVG(pontos) FROM dbo.jogos";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader result = command.ExecuteReader();

                        while (result.Read())
                        {
                            if (string.IsNullOrWhiteSpace(((IDataRecord)result)[0].ToString()) == false)
                            Label5.Text = "Média de pontos por jogo: " + ((IDataRecord)result)[0].ToString();
                        }
                    }
                }

                // MAX
                using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
                {
                    String query = "SELECT MAX(pontos) FROM dbo.jogos";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader result = command.ExecuteReader();

                        while (result.Read())
                        {
                            if (string.IsNullOrWhiteSpace(((IDataRecord)result)[0].ToString()) == false)
                            Label6.Text = "Maior pontuação em um jogo: " + ((IDataRecord)result)[0].ToString();
                        }
                    }
                }

                // MIN
                using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
                {
                    String query = "SELECT MIN(pontos) FROM dbo.jogos";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader result = command.ExecuteReader();

                        while (result.Read())
                        {
                            if (string.IsNullOrWhiteSpace(((IDataRecord)result)[0].ToString()) == false)
                            Label7.Text = "Menor pontuação em um jogo: " + ((IDataRecord)result)[0].ToString();
                        }
                    }
                }

                // trocas de pontos máximos
                using (SqlConnection connection = new SqlConnection("Data Source=HP1/SQLEXPRESS;Initial Catalog=Jogos;Integrated Security=SSPI"))
                {
                    String query = "SELECT pontos FROM dbo.jogos ORDER BY id";
                    int i = 999;
                    int j = 0;
                    int z = 0;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader result = command.ExecuteReader();

                        while (result.Read())
                        {
                            if (j==0)
                            {
                                j = 1;
                                i = (int)((IDataRecord)result)[0];
                            }
                            if ((int)((IDataRecord)result)[0] > i)
                            {
                                z = z + 1;
                                i = (int)((IDataRecord)result)[0];
                            }

                        }
                    }
                    string k;
                    k = z.ToString();
 
                    Label8.Text = "Quantidade de vezes que bateu o próprio recorde: ";
                    Label8.Text = Label8.Text + k ;
                }

            }
        }
    }
}