using Dapper;
using MyFazendaFrame.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyFazendaFrame.Data
{
    public class DapperRepository
    {
        private readonly IDbConnection _connection;

        public DapperRepository()
        {
           _connection = new SqlConnection(@"Server=LAPTOP-4LGACR4L\SQLEXPRESS06;Database=Fazenda;Trusted_Connection=True;");
        }

        public Semente GetSementeCompleteByFrutaId(int id)
        {
            _connection.Open();

            string query = @"
                SELECT
                    *
                FROM SEMENTE WHERE FrutaId = @id
            ";

            Semente s = _connection.QueryFirstOrDefault<Semente>(query, new { id });

            _connection.Close();

            return s;
        }

        public Semente GetSementeByFrutaId(int id)
        {
            _connection.Open();

            string query = @"
                SELECT
                    Preco, 
                    QuantidadePorEmbalagem
                FROM SEMENTE WHERE FrutaId = @id
            ";

            Semente s = _connection.QueryFirstOrDefault<Semente>(query, new { id });

            _connection.Close();

            return s;
        }

        public Semente GetSementeById(int id)
        {
            _connection.Open();

            string query = @"
                SELECT
                    Preco, 
                    QuantidadePorEmbalagem
                FROM SEMENTE WHERE SementeId = @id
            ";

            Semente s = _connection.QueryFirstOrDefault<Semente>(query, new { id });

            _connection.Close();

            return s;
        }

        public IEnumerable<Semente> GetSementes()
        {
            _connection.Open();

            string query = @"
                SELECT
                    Preco, 
                    QuantidadePorEmbalagem
                FROM SEMENTE
            ";

            IEnumerable<Semente> s = _connection.Query<Semente>(query);

            _connection.Close();

            return s;
        }

        public (decimal preco, int quantidade) GetSementeFrutaPrecoEmbalagemById(int frutaId)
        {
            _connection.Open();

            try
            {
                string query = @"
                SELECT 
                    Preco, 
                    QuantidadePorEmbalagem 
                FROM SEMENTE WHERE FrutaId = @frutaId
            ";

                return _connection.QueryFirstOrDefault<(decimal preco, int quantidade)>(query, new { frutaId });
            }
            catch
            {
                return (0, 0);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
