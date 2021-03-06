using DotNetReflector.Tests.Samples;
using FluentAssertions;
using Xunit;

namespace DotNetReflector.Tests
{
    public class TypeReflectorFactoryTests
    {
        [Fact]
        public void When_type_is_specified_via_generic_parameter_then_correct_typereflector_is_returned()
        {
            var factory = new TypeReflectorFactory();

            var specimen = factory.Create<SampleClass>();

            var expected = new TypeReflector(typeof(SampleClass));

            specimen.Should().Be(expected);
        }

        [Fact]
        public void When_type_is_specified_via_type_argument_then_correct_typereflector_is_returned()
        {
            var factory = new TypeReflectorFactory();

            var specimen = factory.Create(typeof(SampleClass));

            var expected = new TypeReflector(typeof(SampleClass));

            specimen.Should().Be(expected);
        }
    }
}
