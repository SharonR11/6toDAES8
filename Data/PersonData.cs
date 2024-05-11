using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PersonData
    {

        public List<Person> Get()
        {
            List<Person> people = new List<Person>();

            using (SqlConnection connection = new SqlConnection(BaseDatos.connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetPeople", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Person person = new Person();
                            person.PersonID = Convert.ToInt32(reader["PersonID"]);
                            person.FirstName = reader["FirstName"].ToString();
                            person.LastName = reader["LastName"].ToString();
                            person.Age = Convert.ToInt32(reader["Age"]);
                            people.Add(person);
                        }
                    }
                }
            }

            return people;
        }
        public void Insert()
        {
        }
        public void Update()
        {
        }
        public void Delete()
        {

        }

    }
}
