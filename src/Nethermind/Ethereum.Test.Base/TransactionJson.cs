/*
 * Copyright (c) 2021 Demerzel Solutions Limited
 * This file is part of the Nethermind library.
 *
 * The Nethermind library is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * The Nethermind library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.
 */

using Nethermind.Core;
using Nethermind.Int256;

namespace Ethereum.Test.Base
{
    public class TransactionJson
    {
        public byte[][]? Data { get; set; }
        public long[]? GasLimit { get; set; }
        public UInt256? GasPrice { get; set; }

        public UInt256? MaxFeePerGas { get; set; }

        public UInt256? MaxPriorityFeePerGas { get; set; }
        public UInt256 Nonce { get; set; }
        public Address? To { get; set; }
        public UInt256[]? Value { get; set; }
        public byte[]? SecretKey { get; set; }

        public AccessListItemJson[]?[]? AccessLists { get; set; }

        public AccessListItemJson[]? AccessList { get; set; }
    }
}
