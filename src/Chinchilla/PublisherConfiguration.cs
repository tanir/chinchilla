using System;
using Chinchilla.Topologies;

namespace Chinchilla
{
    public class PublisherConfiguration : EndpointConfiguration, IPublisherConfiguration, IPublisherBuilder
    {
        private Func<IRouter> routerBuilder = () => new DefaultRouter();

        public IPublisherBuilder RouteWith<TRouter>()
            where TRouter : IRouter, new()
        {
            routerBuilder = () => new TRouter();
            return this;
        }

        public IPublisherBuilder RouteWith(IRouter router)
        {
            routerBuilder = () => router;
            return this;
        }

        public IRouter BuildRouter()
        {
            return routerBuilder();
        }

        public IPublisherBuilder SetTopology(IMessageTopologyBuilder messageTopologyBuilder)
        {
            MessageTopologyBuilder = messageTopologyBuilder;
            return this;
        }
    }
}