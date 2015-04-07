using PartyInvites.Models;
using PartyInvites.Models.Repository;
using PartyInvites.Presenters.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvites.Presenters
{
    public class RSVPPresenter: IPresenter<GuestResponse> 
    {
        public IRepository repository { get; set; }

        public IResult GetResult()
        {
            return new DataResult<GuestResponse>(new GuestResponse());
        }

        public IResult GetResult(GuestResponse requestData)
        {
            repository.AddResponse(requestData);

            if (requestData.WillAttend.Value)
            {
                return new RedirectResult("/Content/seeyouthere.html");
            }
            else
            {
                return new RedirectResult("/Content/sorryyoucantcome.html");
            }
        }
    }
}