using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using GRA.Domain.Entities;
using GRA.Utils;
using Xunit;

namespace GRA.IntegratedTests
{
    public class AwardControllerTest : IntegrationTest
    {
        [Fact]
        public async Task GetIntervalTest()
        {
            //Act
            var response = await TestClient.GetAsync("/Awards");

            //Assert
            response.StatusCode.Should().Be(expected: HttpStatusCode.OK);

            var result = response.Content.ReadAsStringAsync().Result;

            var objResult = result.ToString().StringJsonToObject<AwardResponse>();
            //Teste executado com base no Arquivo CSV Original - Para Outros arquivos Alterar o intervalo esperado
            objResult.Min.FirstOrDefault().Interval.Should().Be(1);
            objResult.Max.FirstOrDefault().Interval.Should().Be(13);

        }
    }
}
