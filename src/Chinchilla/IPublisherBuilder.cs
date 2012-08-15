using Chinchilla.Topologies;

namespace Chinchilla
{
    public interface IPublisherBuilder
    {
        IPublisherBuilder SetTopology(IPublisherTopology publisherTopology);
    }
}