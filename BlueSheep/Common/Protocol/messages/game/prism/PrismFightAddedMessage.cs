









// Generated on 12/11/2014 19:01:57
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class PrismFightAddedMessage : Message
    {
        public new const uint ID =6452;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.PrismFightersInformation fight;
        
        public PrismFightAddedMessage()
        {
        }
        
        public PrismFightAddedMessage(Types.PrismFightersInformation fight)
        {
            this.fight = fight;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            fight.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            fight = new Types.PrismFightersInformation();
            fight.Deserialize(reader);
        }
        
    }
    
}