using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound05.Banco;

internal class Connection
{
    private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound05;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(_connectionString);
    }

    public IEnumerable<Artista> Listar()
    {
        var lista = new List<Artista>();
        using var connection = ObterConexao();
        connection.Open();
    
        string sql = "SELECT * FROM Artistas";
        SqlCommand command = new SqlCommand(sql, connection);
        using SqlDataReader dataReader = command.ExecuteReader();
    
        while (dataReader.Read())
        {
            int idArtista = Convert.ToInt32(dataReader["Id"]);
            string nomeArtista = Convert.ToString(dataReader["Nome"]);
            string bioArtista = Convert.ToString(dataReader["Bio"]);

            Artista artista = new Artista(nomeArtista, bioArtista)
            {
                Id = idArtista
            };

            lista.Add(artista);
        }
        return lista;
    }
}