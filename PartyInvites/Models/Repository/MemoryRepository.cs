using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvites.Models.Repository
{
    public class MemoryRepository : IRepository
    {
        private List<GuestResponse> responses = new List<GuestResponse>();

        public IEnumerable<GuestResponse> GetAllResponses()
        {
            return responses;
        }

        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}