using Chinchilla.Topologies;

namespace Chinchilla
{
    public abstract class EndpointConfiguration : IEndpointConfiguration
    {
        protected EndpointConfiguration()
        {
            MessageTopologyBuilder = new DefaultMessageTopologyBuilder();
        }

        public IMessageTopologyBuilder MessageTopologyBuilder { get; protected set; }

        public IMessageTopology BuildTopology(IEndpoint endpoint)
        {
            return MessageTopologyBuilder.Build(endpoint);
        }
    }
}