using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Clinica_Medica___DATA
{
    public class Pacientes_DAO
    {
        private readonly string _conexao;


        public Pacientes_DAO(string conexao)
        {
            _conexao = conexao;
        }

        public void IncluirPaciente(Pacientes pacientes)
        {
            const string query = @"INSERT INTO Pacientes (nome_paciente, cpf_paciente, dtnasc_paciente, tel_paciente,email_paciente, estadociv_paciente,
                                 tiposang_paciente, rh_paciente, cep_paciente, logradouro_paciente, numero_paciente, bairro_paciente, uf_paciente,
                                 complemento_paciente, cidade_paciente, nomeacomp_paciente, telacomp_paciente)
                                   VALUES(@nome_paciente, @cpf_paciente, @dtnasc_paciente, @tel_paciente, @email_paciente, @estadociv_paciente,
                                 @tiposang_paciente, @rh_paciente, @cep_paciente, @logradouro_paciente, @numero_paciente, @bairro_paciente, @uf_paciente,
                                 @complemento_paciente, @cidade_paciente, @nomeacomp_paciente, @telacomp_paciente)";


            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))

                {
                    comando.Parameters.Add("@nome_paciente", SqlDbType.NVarChar).Value = pacientes.nome_paciente;
                    comando.Parameters.Add("@cpf_paciente", SqlDbType.NVarChar).Value = pacientes.cpf_paciente;
                    comando.Parameters.Add("@dtnasc_paciente", SqlDbType.DateTime).Value = pacientes.dtnasc_paciente;
                    comando.Parameters.Add("@tel_paciente", SqlDbType.NVarChar).Value = pacientes.tel_paciente;
                    comando.Parameters.Add("@email_paciente", SqlDbType.NVarChar).Value = pacientes.email_paciente;
                    comando.Parameters.Add("@estadociv_paciente", SqlDbType.NVarChar).Value = pacientes.estadociv_paciente;
                    comando.Parameters.Add("@tiposang_paciente", SqlDbType.NVarChar).Value = pacientes.tiposang_paciente;
                    comando.Parameters.Add("@rh_paciente", SqlDbType.NVarChar).Value = pacientes.rh_paciente;
                    comando.Parameters.Add("@cep_paciente", SqlDbType.NVarChar).Value = pacientes.cep_paciente;
                    comando.Parameters.Add("@logradouro_paciente", SqlDbType.NVarChar).Value = pacientes.logradouro_paciente;
                    comando.Parameters.Add("@numero_paciente", SqlDbType.NVarChar).Value = pacientes.numero_paciente;
                    comando.Parameters.Add("@bairro_paciente", SqlDbType.NVarChar).Value = pacientes.bairro_paciente;
                    comando.Parameters.Add("@uf_paciente", SqlDbType.NVarChar).Value = pacientes.uf_paciente;
                    comando.Parameters.Add("@complemento_paciente", SqlDbType.NVarChar).Value = pacientes.complemento_paciente;
                    comando.Parameters.Add("@cidade_paciente", SqlDbType.NVarChar).Value = pacientes.cidade_paciente;
                    comando.Parameters.Add("@nomeacomp_paciente", SqlDbType.NVarChar).Value = pacientes.nomeacomp_paciente;
                    comando.Parameters.Add("@telacomp_paciente", SqlDbType.NVarChar).Value = pacientes.telacomp_paciente;

                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao incluir Paciente: {ex.Message}", ex);
            }

        }



        public DataSet BuscaPaciente(string pesquisa = "")
        {
            const string query = "SELECT * FROM Pacientes WHERE nome_paciente LIKE @Pesquisa";

            try
            {
                using (var conexaoBD = new SqlConnection(_conexao))

                using (var comando = new SqlCommand(query, conexaoBD))

                using (var adaptador = new SqlDataAdapter(comando))
                {
                    string parametroPesquisa = $"%{pesquisa}%";

                    comando.Parameters.Add("@Pesquisa", SqlDbType.NVarChar).Value = parametroPesquisa;

                    conexaoBD.Open();

                    var dsPacientes = new DataSet();

                    adaptador.Fill(dsPacientes, "Pacientes");

                    return dsPacientes;

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Medicos: {ex.Message}", ex);
            }
        }

        public void ExcluiPaciente(int codigoPaciente)
        {
            const string query = "DELETE FROM Pacientes WHERE cod_paciente = @cod_paciente";

            try
            {
                using (var conexaoBD = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBD))
                {
                    comando.Parameters.Add("@cod_paciente", SqlDbType.Int).Value = codigoPaciente;

                    conexaoBD.Open();
                    comando.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro de Banco de dados ao excluir o Médico: {ex.Message}", ex);
            }

            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir o Médico:{ex.Message}", ex);
            }
        }

        public Pacientes ObtemPacientes(int codigoPaciente)
        {
            const string query = "SELECT * FROM Pacientes WHERE cod_paciente = @Codigo_paciente";
            Pacientes pacientes = null;

            try
            {
                using (var conexaoBD = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBD))
                {
                    comando.Parameters.AddWithValue("@Codigo_paciente", codigoPaciente);

                    conexaoBD.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            pacientes = new Pacientes
                            {
                             cod_paciente = Convert.ToInt32(reader["cod_paciente"]),
                             nome_paciente = reader["nome_paciente"].ToString(),
                             cpf_paciente = reader.IsDBNull(reader.GetOrdinal("cpf_paciente")) ? null : reader["cpf_paciente"].ToString(),
                             dtnasc_paciente = (DateTime)reader["dtnasc_paciente"],
                             tel_paciente = reader.IsDBNull(reader.GetOrdinal("tel_paciente")) ? null : reader["tel_paciente"].ToString(),
                             email_paciente = reader.IsDBNull(reader.GetOrdinal("email_paciente")) ? null : reader["email_paciente"].ToString(),
                             estadociv_paciente = reader.IsDBNull(reader.GetOrdinal("estadociv_paciente")) ? null : reader["estadociv_paciente"].ToString(),
                             tiposang_paciente = reader.IsDBNull(reader.GetOrdinal("tiposang_paciente")) ? null : reader["tiposang_paciente"].ToString(),
                             rh_paciente = reader.IsDBNull(reader.GetOrdinal("rh_paciente")) ? null : reader["rh_paciente"].ToString(),
                             cep_paciente = reader.IsDBNull(reader.GetOrdinal("cep_paciente")) ? null : reader["cep_paciente"].ToString(),
                             logradouro_paciente = reader.IsDBNull(reader.GetOrdinal("logradouro_paciente")) ? null : reader["logradouro_paciente"].ToString(),
                             numero_paciente = reader.IsDBNull(reader.GetOrdinal("numero_paciente")) ? null : reader["numero_paciente"].ToString(),
                             bairro_paciente = reader.IsDBNull(reader.GetOrdinal("bairro_paciente")) ? null : reader["bairro_paciente"].ToString(),
                             uf_paciente = reader.IsDBNull(reader.GetOrdinal("uf_paciente")) ? null : reader["uf_paciente"].ToString(),
                             complemento_paciente = reader["complemento_paciente"].ToString(),
                             cidade_paciente = reader.IsDBNull(reader.GetOrdinal("cidade_paciente")) ? null : reader["cidade_paciente"].ToString(),
                             nomeacomp_paciente = reader["nomeacomp_paciente"].ToString(),
                             telacomp_paciente = reader["telacomp_paciente"].ToString(),

                            };
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter o Paciente:{ex.Message}", ex);
            }
            return pacientes;
            
        }

        public void AlteraPacientes(Pacientes pacientes)
        {

            const string query = @"UPDATE Pacientes SET nome_paciente = @nome_paciente,
                                                        cpf_paciente = @cpf_paciente,
                                                        dtnasc_paciente = @dtnasc_paciente,
                                                        tel_paciente = @tel_paciente, 
                                                        email_paciente = @email_paciente,
                                                        estadociv_paciente = @estadociv_paciente,
                                                        tiposang_paciente = @tiposang_paciente,
                                                        rh_paciente = @rh_paciente,
                                                        cep_paciente = @cep_paciente,
                                                        logradouro_paciente = @logradouro_paciente,
                                                        numero_paciente = @numero_paciente,
                                                        bairro_paciente = @bairro_paciente,
                                                        uf_paciente = @uf_paciente,
                                                        complemento_paciente = @complemento_paciente,
                                                        cidade_paciente = @cidade_paciente,
                                                        nomeacomp_paciente = @nomeacomp_paciente,
                                                        telacomp_paciente = @telacomp_paciente
                                                        WHERE cod_paciente = @cod_paciente";

            try
            {
                using (var conexaoBD = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBD))
                {
                    comando.Parameters.Add("@nome_paciente", SqlDbType.NVarChar).Value = pacientes.nome_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@cpf_paciente", SqlDbType.NVarChar).Value = pacientes.cpf_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@dtnasc_paciente", SqlDbType.DateTime).Value = pacientes.dtnasc_paciente;
                    comando.Parameters.Add("@tel_paciente", SqlDbType.NVarChar).Value = pacientes.tel_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@email_paciente", SqlDbType.NVarChar).Value = pacientes.email_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@estadociv_paciente", SqlDbType.NVarChar).Value = pacientes.estadociv_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@tiposang_paciente", SqlDbType.NVarChar).Value = pacientes.tiposang_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@rh_paciente", SqlDbType.NVarChar).Value = pacientes.rh_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@cep_paciente", SqlDbType.NVarChar).Value = pacientes.cep_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@logradouro_paciente", SqlDbType.NVarChar).Value = pacientes.logradouro_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@numero_paciente", SqlDbType.NVarChar).Value = pacientes.numero_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@bairro_paciente", SqlDbType.NVarChar).Value = pacientes.bairro_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@uf_paciente", SqlDbType.NVarChar).Value = pacientes.uf_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@complemento_paciente", SqlDbType.NVarChar).Value = pacientes.complemento_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@cidade_paciente", SqlDbType.NVarChar).Value = pacientes.cidade_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@nomeacomp_paciente", SqlDbType.NVarChar).Value = pacientes.nomeacomp_paciente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@telacomp_paciente", SqlDbType.NVarChar).Value = pacientes.telacomp_paciente ?? (object)DBNull.Value;

                    comando.Parameters.Add("@cod_paciente", SqlDbType.NVarChar).Value = pacientes.cod_paciente;

                    conexaoBD.Open();

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro de Banco de dados ao alterar o Paciente: {ex.Message}", ex);
            }

            catch (Exception ex)
            {
                throw new Exception($"Erro ao alterar o Paciente:{ex.Message}", ex);
            }

        }
    }
}
