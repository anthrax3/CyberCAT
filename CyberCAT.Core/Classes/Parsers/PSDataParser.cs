﻿using System;
using System.Collections.Generic;
using System.IO;
using CyberCAT.Core.Classes.Interfaces;

namespace CyberCAT.Core.Classes.Parsers
{
    public class PSDataParser : GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }

        public PSDataParser()
        {
            ParsableNodeName = Constants.NodeNames.PS_DATA;
            DisplayName = "Persistency System Data Parser";
            Guid = Guid.Parse("{2D4A30D4-C2D9-4ED5-A0CA-2457B2DF228B}");
        }

        public new object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            //var result = base.ReadWithMapping(node, reader, parsers);
            var result = base.ReadWithMapping(node, reader, parsers);

            return result;
        }
    }
}