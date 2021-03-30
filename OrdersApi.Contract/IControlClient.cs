using OrdersApi.Model;
using System.Collections.Generic;

namespace OrdersApi.Contract
{
    public interface IControlClient
    {
        void AddClient(Client client);

        Client SearchClient(long id);

        List<Client> ListClient();

        void DeleteClient(long id);


    }
}
