//  Copyright (c) 2018 Demerzel Solutions Limited
//  This file is part of the Nethermind library.
// 
//  The Nethermind library is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  The Nethermind library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.

using System.Linq;
using Nethermind.DataMarketplace.Consumers.Sessions.Domain;
using Nethermind.DataMarketplace.Infrastructure.Rpc.Models;

namespace Nethermind.DataMarketplace.Consumers.Infrastructure.Rpc.Models
{
    public class ConsumerSessionForRpc : SessionForRpc
    {
        public uint ConsumedUnitsFromProvider { get; }
        public string DataAvailability { get; }
        public SessionClientForRpc[] Clients { get; }

        public ConsumerSessionForRpc(ConsumerSession session) : base(session)
        {
            ConsumedUnitsFromProvider = session.ConsumedUnitsFromProvider;
            DataAvailability = session.DataAvailability.ToString().ToLowerInvariant();
            Clients = session.Clients.Select(c => new SessionClientForRpc(c)).ToArray();
        }
    }
}
