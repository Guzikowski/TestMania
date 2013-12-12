using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using BookCatalogService.Data;
using BookCatalogService.Domain;
using IBookCatalogService.Domain;

namespace BookCatalogService
{
    public class LegacyCode
    {
       public void LookupBook( int index)
       {
            BookDetail book;
			
				using (var connection = new DatabaseConnectionProvider().GetConnection())
				{

                    SqlConnection sqlConnection = new SqlConnection("Data Source={0};Initial Catalog={1};User Id={2};Password={3}");

                    sqlConnection.Open();

                    var command = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        Connection = connection,
                        CommandText = "Select * from Books where bookid = @BookId"
                    };
                    command.Parameters.AddWithValue("@BookId", index);
                    using (var reader = command.ExecuteReader())
                    {

                        book = new BookDetail
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Author = new AuthorDetail
                            {
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName"))
                            },
                        };
                    }
                   
                }
      }


    }
}
