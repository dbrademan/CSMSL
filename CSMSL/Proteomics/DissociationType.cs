﻿// Copyright 2012, 2013, 2014 Derek J. Bailey
// 
// This file (DissociationType.cs) is part of CSMSL.
// 
// CSMSL is free software: you can redistribute it and/or modify it
// under the terms of the GNU Lesser General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CSMSL is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
// FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public
// License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with CSMSL. If not, see <http://www.gnu.org/licenses/>.

namespace CSMSL.Proteomics
{
    public enum DissociationType
    {
        UnKnown = -1,
        None = 6,
        CID = 0,
        HCD = 5,
        ETD = 4,
        MPD = 1,
        ECD = 2,
        PQD = 3,
        SA = 7,
        PTR = 8,
        NETD = 9,
        NPTR = 10,
        CI = 11,
        AI_ETD = 12
    }
}