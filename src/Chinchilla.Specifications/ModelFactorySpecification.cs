﻿using Machine.Fakes;
using Machine.Specifications;

namespace Chinchilla.Specifications
{
    public class ModelFactorySpecification
    {
        [Subject(typeof(ModelFactory))]
        public class when_creating_model : WithSubject<ModelFactory>
        {
            Because of = () =>
                reference = Subject.CreateModel();

            It should_be_tracking_reference = () =>
                Subject.IsTracking(reference).ShouldBeTrue();

            It should_have_num_references = () =>
                Subject.NumReferences.ShouldEqual(1);

            static IModelReference reference;
        }

        [Subject(typeof(ModelFactory))]
        public class when_disposing_of_model_reference : WithSubject<ModelFactory>
        {
            Establish context = () =>
                reference = Subject.CreateModel();

            Because of = () =>
                reference.Dispose();

            It should_untrack_reference = () =>
                Subject.IsTracking(reference).ShouldBeFalse();

            static IModelReference reference;
        }
    }
}
