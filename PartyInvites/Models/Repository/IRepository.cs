using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PartyInvites.Models;

namespace PartyInvites.Models.Repository
{
    interface IRepository
    {
        IEnumerable<PartyInvites.Models.GuestResponse> GetAllResponses();
        void AddResponse(GuestResponse response);
    }
}
