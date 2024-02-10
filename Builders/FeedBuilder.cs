using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Builders;

public class FeedBuilder
{
    private string _feedOwner = string.Empty;

    public Feed Build()
    {
        return new Feed()
        {
        };
    }    
}
