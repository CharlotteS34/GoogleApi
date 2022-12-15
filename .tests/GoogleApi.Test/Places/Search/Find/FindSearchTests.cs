using System;
using System.Linq;
using System.Threading;
using GoogleApi.Entities.Common;
using GoogleApi.Entities.Common.Enums;
using GoogleApi.Entities.Places.Common;
using GoogleApi.Entities.Places.Search.Find.Request;
using GoogleApi.Entities.Places.Search.Find.Request.Enums;
using NUnit.Framework;

namespace GoogleApi.Test.Places.Search.Find;

[TestFixture]
public class FindSearchTests : BaseTest
{
    [Test]
    public void PlacesFindSearchTest()
    {
        var request = new PlacesFindSearchRequest
        {
            Key = this.Settings.ApiKey,
            Input = "picadelly circus",
            Type = InputType.TextQuery,
            Fields = FieldTypes.Basic
        };

        var response = GooglePlaces.Search.FindSearch.Query(request);

        Assert.IsNotNull(response);
        Assert.AreEqual(Status.Ok, response.Status);

        var candidate = response.Candidates.FirstOrDefault();
        Assert.IsNotNull(candidate);
        Assert.IsNotNull(candidate.PlaceId);
        Assert.AreEqual(candidate.BusinessStatus, BusinessStatus.Operational);
    }

    [Test]
    public void PlacesFindSearchWhenTypeIsPhoneNumberTest()
    {
        var request = new PlacesFindSearchRequest
        {
            Key = this.Settings.ApiKey,
            Input = "+4533333333",
            Type = InputType.PhoneNumber
        };

        var response = GooglePlaces.Search.FindSearch.Query(request);

        Assert.IsNotNull(response);
        Assert.AreEqual(Status.Ok, response.Status);
    }

    [Test]
    public void PlacesFindSearchAsyncTest()
    {
        var request = new PlacesFindSearchRequest
        {
            Key = this.Settings.ApiKey,
            Input = "picadelly circus"
        };

        var response = GooglePlaces.Search.FindSearch.QueryAsync(request).Result;

        Assert.IsNotNull(response);
        Assert.AreEqual(Status.Ok, response.Status);
    }

    [Test]
    public void PlacesFindSearchWhenAsyncAndCancelledTest()
    {
        var request = new PlacesFindSearchRequest
        {
            Key = this.Settings.ApiKey,
            Input = "picadelly circus"
        };

        var cancellationTokenSource = new CancellationTokenSource();
        var task = GooglePlaces.Search.FindSearch.QueryAsync(request, cancellationTokenSource.Token);
        cancellationTokenSource.Cancel();

        var exception = Assert.Throws<OperationCanceledException>(() => task.Wait(cancellationTokenSource.Token));
        Assert.IsNotNull(exception);
        Assert.AreEqual(exception.Message, "The operation was canceled.");
    }

    [Test]
    public void PlacesFindSearchWhenFieldsTest()
    {
        var request = new PlacesFindSearchRequest
        {
            Key = this.Settings.ApiKey,
            Input = "picadelly circus",
            Type = InputType.TextQuery,
            Fields = FieldTypes.Basic
        };

        var response = GooglePlaces.Search.FindSearch.Query(request);

        Assert.IsNotNull(response);
        Assert.AreEqual(Status.Ok, response.Status);

        var candidate = response.Candidates.FirstOrDefault();
        Assert.IsNotNull(candidate);
        Assert.IsNotNull(candidate.Name);
        Assert.IsNotNull(candidate.Icon);
        Assert.IsNotNull(candidate.PlaceId);
        Assert.IsNotNull(candidate.Geometry);
        Assert.IsNotNull(candidate.Geometry.Location);
        Assert.IsNotNull(candidate.Geometry.ViewPort);
    }

    [Test]
    public void PlacesFindSearchWhenLocationBiasAndIpBiasTest()
    {
        var request = new PlacesFindSearchRequest
        {
            Key = this.Settings.ApiKey,
            Input = "jagtvej 2200 K�benhavn",
            LocationBias = new LocationBias
            {
                IpBias = true
            }
        };

        var response = GooglePlaces.Search.FindSearch.Query(request);

        Assert.IsNotNull(response);
        Assert.AreEqual(Status.Ok, response.Status);
    }

    [Test]
    public void PlacesFindSearchWhenLocationBiasAndPointTest()
    {
        Assert.Inconclusive("Documentation states that 'point' bias is possible, but Google returns invalid request");

        //var request = new PlacesFindSearchRequest
        //{
        //    Key = this.Settings.ApiKey,
        //    Input = "jagtvej 2200 K�benhavn",
        //    LocationBias = new LocationBias
        //    {
        //        Location = new Coordinate(55.69987296762697, 12.552359427579363)
        //    }
        //};

        //var response = GooglePlaces.AutoComplete.Query(request);

        //Assert.IsNotNull(response);
        //Assert.AreEqual(Status.Ok, response.Status);
    }

    [Test]
    public void PlacesFindSearchWhenLocationBiasAndCircleTest()
    {
        var request = new PlacesFindSearchRequest
        {
            Key = this.Settings.ApiKey,
            Input = "jagtvej 2200 K�benhavn",
            LocationBias = new LocationBias
            {
                Location = new Coordinate(1, 1),
                Radius = 1000
            }
        };

        var response = GooglePlaces.Search.FindSearch.Query(request);

        Assert.IsNotNull(response);
        Assert.AreEqual(Status.Ok, response.Status);
    }

    [Test]
    public void PlacesFindSearchWhenLocationBiasAndRectangularTest()
    {
        var request = new PlacesFindSearchRequest
        {
            Key = this.Settings.ApiKey,
            Input = "jagtvej 2200 K�benhavn",
            LocationBias = new LocationBias
            {
                Bounds = new ViewPort(new Coordinate(1, 1), new Coordinate(2, 2))
            }
        };

        var response = GooglePlaces.Search.FindSearch.Query(request);

        Assert.IsNotNull(response);
        Assert.AreEqual(Status.Ok, response.Status);
    }

    [Test]
    public void PlacesFindSearchWhenLocationRestrictionAndCircleTest()
    {
        var request = new PlacesFindSearchRequest
        {
            Key = this.Settings.ApiKey,
            Input = "jagtvej 2200 K�benhavn",
            LocationRestriction = new LocationRestriction
            {
                Location = new Coordinate(55.69987296762697, 12.552359427579363),
                Radius = 50000
            }
        };

        var response = GooglePlaces.Search.FindSearch.Query(request);

        Assert.IsNotNull(response);
        Assert.AreEqual(Status.Ok, response.Status);
    }

    [Test]
    public void PlacesFindSearchWhenLocationRestrictionAndRectangularTest()
    {
        var request = new PlacesFindSearchRequest
        {
            Key = this.Settings.ApiKey,
            Input = "jagtvej 2200 K�benhavn",
            LocationRestriction = new LocationRestriction
            {
                Bounds = new ViewPort(new Coordinate(54.69987296762697, 11.552359427579363), new Coordinate(56.69987296762697, 13.552359427579363))
            }
        };

        var response = GooglePlaces.Search.FindSearch.Query(request);

        Assert.IsNotNull(response);
        Assert.AreEqual(Status.Ok, response.Status);
    }
}