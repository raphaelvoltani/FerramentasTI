using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Clinica_Medica___DATA
{
    public class Medicos_DAO
    {
        private readonly string _conexao;


        public Medicos_DAO(string conexao)
        {
            _conexao = conexao;
        }

        public DataSet BuscaMedico(string pesquisa = "")
        {
            const string query = "SELECT * FROM Medicos WHERE nome_medico LIKE @Pesquisa";

            try
            {
                using (var conexaoBD = new SqlConnection(_conexao))

                using (var comando = new SqlCommand(query, conexaoBD))

                using (var adaptador =  new SqlDataAdapter(comando))
                {
                    string parametroPesquisa = $"%{pesquisa}%";

                    comando.Parameters.Add("@Pesquisa", SqlDbType.NVarChar).Value = parametroPesquisa;

                    conexaoBD.Open();

                    var dsMedicos = new DataSet();

                    adaptador.Fill(dsMedicos, "Medicos");

                    return dsMedicos;

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Medicos: {ex.Message}",ex);
            }
        }

        public void IncluirMedico(Medicos medicos)
        {
            const string query = @"INSERT INTO Medicos (nome_medico, cpf_medico, dtnasc_medico, tel_medico, email_medico, crm_medico, espec_medico)
                                   VALUES(@nome_medico, @cpf_medico, @dtnasc_medico, @tel_medico, @email_medico, @crm_medico, @espec_medico)";



            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))

                {
                    comando.Parameters.Add("@nome_medico", SqlDbType.NVarChar).Value = medicos.nome_medico;
                    comando.Parameters.Add("@cpf_medico", SqlDbType.NVarChar).Value = medicos.cpf_medico;
                    comando.Parameters.Add("@dtnasc_medico", SqlDbType.DateTime).Value = medicos.dtnasc_medico;
                    comando.Parameters.Add("@tel_medico", SqlDbType.NVarChar).Value = medicos.tel_medico;
                    comando.Parameters.Add("@email_medico", SqlDbType.NVarChar).Value = medicos.email_medico;
                    comando.Parameters.Add("@crm_medico", SqlDbType.NVarChar).Value = medicos.crm_medico;
                    comando.Parameters.Add("@espec_medico", SqlDbType.NVarChar).Value = medicos.espec_medico;

                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao incluir Médico: {ex.Message}", ex);
            }
        }

        

        public void ExcluiMedico(int codigoMedico)
        {
            const string query = "DELETE FROM Medicos WHERE cod_medico = @cod_medico";
            

            try
            {
                using (var conexaoBD = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBD))
                {
                    comando.Parameters.Add("@cod_medico", SqlDbType.Int).Value = codigoMedico;

                    conexaoBD.Open();
                    comando.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro de Banco de dados ao excluir o Médico: {ex.Message}",ex);
            }

            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir o Médico:{ex.Message}",ex);
            }
        }

        public Medicos ObtemMedicos(int codigoMedico)
        {
            const string query = "SELECT * FROM Medicos WHERE cod_medico = @Codigo_medico";
            Medicos medicos = null;

            try
            {
                using (var conexaoBD = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBD))
                {
                    comando.Parameters.AddWithValue("@Codigo_medico", codigoMedico);

                    conexaoBD.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            medicos = new Medicos
                            {
                                cod_medico = Convert.ToInt32(reader["cod_medico"]),
                                nome_medico = reader["nome_medico"].ToString(),
                                cpf_medico = reader.IsDBNull(reader.GetOrdinal("cpf_medico")) ? null : reader["cpf_medico"].ToString(),
                                dtnasc_medico = (DateTime)reader["dtnasc_medico"],
                                tel_medico = reader.IsDBNull(reader.GetOrdinal("tel_medico")) ? null : reader["tel_medico"].ToString(),
                                email_medico = reader.IsDBNull(reader.GetOrdinal("email_medico")) ? null : reader["email_medico"].ToString(),
                                crm_medico = reader.IsDBNull(reader.GetOrdinal("crm_medico")) ? null : reader["crm_medico"].ToString(),
                                espec_medico = reader.IsDBNull(reader.GetOrdinal("espec_medico")) ? null : reader["espec_medico"].ToString(),
                            };
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter o Médico:{ex.Message}", ex);
            }
            return medicos;

        }

        public void AlteraMedicos(Medicos medicos)
        {

            const string query = @"UPDATE Medicos SET nome_medico = @nome_medico,
                                                      cpf_medico = @cpf_medico,
                                                      dtnasc_medico = @dtnasc_medico,
                                                      tel_medico = @tel_medico, 
                                                      email_medico = @email_medico,
                                                      crm_medico = @crm_medico,
                                                      espec_medico = @espec_medico
                                                      WHERE cod_medico = @cod_medico";

            try
            {
                using (var conexaoBD = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBD))
                {
                    comando.Parameters.Add("@nome_medico", SqlDbType.NVarChar).Value = medicos.nome_medico ?? (object)DBNull.Value;
                    comando.Parameters.Add("@cpf_medico", SqlDbType.NVarChar).Value = medicos.cpf_medico ?? (object)DBNull.Value;
                    comando.Parameters.Add("@dtnasc_medico", SqlDbType.DateTime).Value = medicos.dtnasc_medico;
                    comando.Parameters.Add("@tel_medico", SqlDbType.NVarChar).Value = medicos.tel_medico ?? (object)DBNull.Value;
                    comando.Parameters.Add("@email_medico", SqlDbType.NVarChar).Value = medicos.email_medico ?? (object)DBNull.Value;
                    comando.Parameters.Add("@crm_medico", SqlDbType.NVarChar).Value = medicos.crm_medico ?? (object)DBNull.Value;
                    comando.Parameters.Add("@espec_medico", SqlDbType.NVarChar).Value = medicos.espec_medico ?? (object)DBNull.Value;

                    comando.Parameters.Add("@cod_medico", SqlDbType.NVarChar).Value = medicos.cod_medico;

                    conexaoBD.Open();

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro de Banco de dados ao alterar o Médico: {ex.Message}", ex);
            }

            catch (Exception ex)
            {
                throw new Exception($"Erro ao alterar o Médico:{ex.Message}", ex);
            }

        }
    }
}
