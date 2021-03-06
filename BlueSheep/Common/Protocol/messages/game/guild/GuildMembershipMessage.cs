









// Generated on 12/11/2014 19:01:45
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GuildMembershipMessage : GuildJoinedMessage
    {
        public new const uint ID =5835;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public GuildMembershipMessage()
        {
        }
        
        public GuildMembershipMessage(Types.GuildInformations guildInfo, int memberRights, bool enabled)
         : base(guildInfo, memberRights, enabled)
        {
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}