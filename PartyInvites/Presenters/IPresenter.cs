﻿using PartyInvites.Presenters.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyInvites.Presenters
{
    public interface IPresenter<T>
    {
        IResult GetResult();

        IResult GetResult(T requestData);
    }
}
