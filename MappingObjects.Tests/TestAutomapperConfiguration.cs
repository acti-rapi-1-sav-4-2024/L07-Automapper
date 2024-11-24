using AutoMapper;
using MappingObjects.Mappers;

namespace MappingObjects.Tests;

public class TestAutomapperConfiguration
{
    [Fact]
    public void TestSummaryMapping()
    {
        MapperConfiguration configuration = CartToSummaryMapper.GetMapperConfiguration();
        configuration.AssertConfigurationIsValid();
    }
}