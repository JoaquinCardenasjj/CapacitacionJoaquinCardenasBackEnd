using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNexos.MethodParameters
{

    public enum Result
    {
        Success,
        Error,
        GenericError,
        UserBlocked,
        OldPassword,
        InvalidSession,
        NoDaysOperation,
        NoHoursOperation,
        ProfileExists,
        AssociatedUsers,
        SendMailError,
        NoRecords,
        UserExists
    }

}
