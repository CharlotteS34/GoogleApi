using System;
using System.Linq;
using System.Threading;
using GoogleApi.Entities.Common.Enums;
using GoogleApi.Entities.Translate.Languages.Request;
using NUnit.Framework;
using Language = GoogleApi.Entities.Translate.Common.Enums.Language;

namespace GoogleApi.Test.Translate.Languages;

[TestFixture]
public class LanguagesTests : BaseTest
{
    [Test]
    public void LanguagesTest()
    {
        var request = new LanguagesRequest
        {
            Key = this.Settings.ApiKey
        };

        var result = GoogleTranslate.Languages.Query(request);
        Assert.IsNotNull(result);
        Assert.AreEqual(Status.Ok, result.Status);

        var languages = result.Data.Languages;
        Assert.IsNotNull(languages);
        Assert.AreEqual(136, languages.Count());
    }

    [Test]
    public void LanguagesWhenTargetTest()
    {
        var request = new LanguagesRequest
        {
            Key = this.Settings.ApiKey,
            Target = Language.English
        };

        var result = GoogleTranslate.Languages.Query(request);
        Assert.IsNotNull(result);
        Assert.AreEqual(Status.Ok, result.Status);

        var languages = result.Data.Languages;
        Assert.IsNotNull(languages);
        Assert.AreEqual(136, languages.Count());
    }

    [Test]
    public void LanguagesWhenAsyncTest()
    {
        var request = new LanguagesRequest
        {
            Key = this.Settings.ApiKey,
            Target = Language.English
        };

        var result = GoogleTranslate.Languages.QueryAsync(request).Result;
        Assert.IsNotNull(result);
        Assert.AreEqual(Status.Ok, result.Status);
    }

    [Test]
    public void LanguagesWhenAsyncAndCancelledTest()
    {
        var request = new LanguagesRequest
        {
            Key = this.Settings.ApiKey,
            Target = Language.English
        };

        var cancellationTokenSource = new CancellationTokenSource();
        var task = GoogleTranslate.Languages.QueryAsync(request, cancellationTokenSource.Token);
        cancellationTokenSource.Cancel();

        var exception = Assert.Throws<OperationCanceledException>(() => task.Wait(cancellationTokenSource.Token));
        Assert.IsNotNull(exception);
        Assert.AreEqual(exception.Message, "The operation was canceled.");
    }
}