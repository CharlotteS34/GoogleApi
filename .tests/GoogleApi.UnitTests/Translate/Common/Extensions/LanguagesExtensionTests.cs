using GoogleApi.Entities.Translate.Common.Enums;
using GoogleApi.Entities.Translate.Common.Enums.Extensions;
using NUnit.Framework;

namespace GoogleApi.UnitTests.Translate.Common.Extensions;

[TestFixture]
public class LanguagesExtensionTests
{
    [Test]
    public void ToCodeWhenAfrikaansTest()
    {
        Assert.AreEqual("af", Language.Afrikaans.ToCode());
    }

    [Test]
    public void ToCodeWhenAlbanianTest()
    {
        Assert.AreEqual("sq", Language.Albanian.ToCode());
    }

    [Test]
    public void ToCodeWhenAmharicTest()
    {
        Assert.AreEqual("am", Language.Amharic.ToCode());
    }

    [Test]
    public void ToCodeWhenArabicTest()
    {
        Assert.AreEqual("ar", Language.Arabic.ToCode());
    }

    [Test]
    public void ToCodeWhenArmenianTest()
    {
        Assert.AreEqual("hy", Language.Armenian.ToCode());
    }

    [Test]
    public void ToCodeWhenAzeerbaijaniTest()
    {
        Assert.AreEqual("az", Language.Azeerbaijani.ToCode());
    }

    [Test]
    public void ToCodeWhenBasqueTest()
    {
        Assert.AreEqual("eu", Language.Basque.ToCode());
    }

    [Test]
    public void ToCodeWhenBelarusianTest()
    {
        Assert.AreEqual("be", Language.Belarusian.ToCode());
    }

    [Test]
    public void ToCodeWhenBengaliTest()
    {
        Assert.AreEqual("bn", Language.Bengali.ToCode());
    }

    [Test]
    public void ToCodeWhenBosnianTest()
    {
        Assert.AreEqual("bs", Language.Bosnian.ToCode());
    }

    [Test]
    public void ToCodeWhenBulgarianTest()
    {
        Assert.AreEqual("bg", Language.Bulgarian.ToCode());
    }

    [Test]
    public void ToCodeWhenCatalanTest()
    {
        Assert.AreEqual("ca", Language.Catalan.ToCode());
    }

    [Test]
    public void ToCodeWhenCebuanoTest()
    {
        Assert.AreEqual("ceb", Language.Cebuano.ToCode());
    }

    [Test]
    public void ToCodeWhenChichewaTest()
    {
        Assert.AreEqual("ny", Language.Chichewa.ToCode());
    }

    [Test]
    public void ToCodeWhenChinese_SimplifiedTest()
    {
        Assert.AreEqual("zh-CN", Language.Chinese_Simplified.ToCode());
    }

    [Test]
    public void ToCodeWhenChinese_TraditionalTest()
    {
        Assert.AreEqual("zh-TW", Language.Chinese_Traditional.ToCode());
    }

    [Test]
    public void ToCodeWhenCorsicanTest()
    {
        Assert.AreEqual("co", Language.Corsican.ToCode());
    }

    [Test]
    public void ToCodeWhenCroatianTest()
    {
        Assert.AreEqual("hr", Language.Croatian.ToCode());
    }

    [Test]
    public void ToCodeWhenCzechTest()
    {
        Assert.AreEqual("cs", Language.Czech.ToCode());
    }

    [Test]
    public void ToCodeWhenDanishTest()
    {
        Assert.AreEqual("da", Language.Danish.ToCode());
    }

    [Test]
    public void ToCodeWhenDutchTest()
    {
        Assert.AreEqual("nl", Language.Dutch.ToCode());
    }

    [Test]
    public void ToCodeWhenEnglishTest()
    {
        Assert.AreEqual("en", Language.English.ToCode());
    }

    [Test]
    public void ToCodeWhenEsperantoTest()
    {
        Assert.AreEqual("eo", Language.Esperanto.ToCode());
    }

    [Test]
    public void ToCodeWhenEstonianTest()
    {
        Assert.AreEqual("et", Language.Estonian.ToCode());
    }

    [Test]
    public void ToCodeWhenFilipinoTest()
    {
        Assert.AreEqual("tl", Language.Filipino.ToCode());
    }

    [Test]
    public void ToCodeWhenFinnishTest()
    {
        Assert.AreEqual("fi", Language.Finnish.ToCode());
    }

    [Test]
    public void ToCodeWhenFrenchTest()
    {
        Assert.AreEqual("fr", Language.French.ToCode());
    }

    [Test]
    public void ToCodeWhenFrisianTest()
    {
        Assert.AreEqual("fy", Language.Frisian.ToCode());
    }

    [Test]
    public void ToCodeWhenGalicianTest()
    {
        Assert.AreEqual("gl", Language.Galician.ToCode());
    }

    [Test]
    public void ToCodeWhenGeorgianTest()
    {
        Assert.AreEqual("ka", Language.Georgian.ToCode());
    }

    [Test]
    public void ToCodeWhenGermanTest()
    {
        Assert.AreEqual("de", Language.German.ToCode());
    }

    [Test]
    public void ToCodeWhenGreekTest()
    {
        Assert.AreEqual("el", Language.Greek.ToCode());
    }

    [Test]
    public void ToCodeWhenGujaratiTest()
    {
        Assert.AreEqual("gu", Language.Gujarati.ToCode());
    }

    [Test]
    public void ToCodeWhenHaitian_CreoleTest()
    {
        Assert.AreEqual("ht", Language.Haitian_Creole.ToCode());
    }

    [Test]
    public void ToCodeWhenHausaTest()
    {
        Assert.AreEqual("ha", Language.Hausa.ToCode());
    }

    [Test]
    public void ToCodeWhenHawaiianTest()
    {
        Assert.AreEqual("haw", Language.Hawaiian.ToCode());
    }

    [Test]
    public void ToCodeWhenHebrewTest()
    {
        Assert.AreEqual("iw", Language.Hebrew.ToCode());
    }

    [Test]
    public void ToCodeWhenHindiTest()
    {
        Assert.AreEqual("hi", Language.Hindi.ToCode());
    }

    [Test]
    public void ToCodeWhenHmongTest()
    {
        Assert.AreEqual("hmn", Language.Hmong.ToCode());
    }

    [Test]
    public void ToCodeWhenHungarianTest()
    {
        Assert.AreEqual("hu", Language.Hungarian.ToCode());
    }

    [Test]
    public void ToCodeWhenIcelandicTest()
    {
        Assert.AreEqual("is", Language.Icelandic.ToCode());
    }

    [Test]
    public void ToCodeWhenIgboTest()
    {
        Assert.AreEqual("ig", Language.Igbo.ToCode());
    }

    [Test]
    public void ToCodeWhenIndonesianTest()
    {
        Assert.AreEqual("id", Language.Indonesian.ToCode());
    }

    [Test]
    public void ToCodeWhenIrishTest()
    {
        Assert.AreEqual("ga", Language.Irish.ToCode());
    }

    [Test]
    public void ToCodeWhenItalianTest()
    {
        Assert.AreEqual("it", Language.Italian.ToCode());
    }

    [Test]
    public void ToCodeWhenJapaneseTest()
    {
        Assert.AreEqual("ja", Language.Japanese.ToCode());
    }

    [Test]
    public void ToCodeWhenJavaneseTest()
    {
        Assert.AreEqual("jw", Language.Javanese.ToCode());
    }

    [Test]
    public void ToCodeWhenKannadaTest()
    {
        Assert.AreEqual("kn", Language.Kannada.ToCode());
    }

    [Test]
    public void ToCodeWhenKazakhTest()
    {
        Assert.AreEqual("kk", Language.Kazakh.ToCode());
    }

    [Test]
    public void ToCodeWhenKhmerTest()
    {
        Assert.AreEqual("km", Language.Khmer.ToCode());
    }

    [Test]
    public void ToCodeWhenKoreanTest()
    {
        Assert.AreEqual("ko", Language.Korean.ToCode());
    }

    [Test]
    public void ToCodeWhenKurdishTest()
    {
        Assert.AreEqual("ku", Language.Kurdish.ToCode());
    }

    [Test]
    public void ToCodeWhenKyrgyzTest()
    {
        Assert.AreEqual("ky", Language.Kyrgyz.ToCode());
    }

    [Test]
    public void ToCodeWhenLaoTest()
    {
        Assert.AreEqual("lo", Language.Lao.ToCode());
    }

    [Test]
    public void ToCodeWhenLatinTest()
    {
        Assert.AreEqual("la", Language.Latin.ToCode());
    }

    [Test]
    public void ToCodeWhenLatvianTest()
    {
        Assert.AreEqual("lv", Language.Latvian.ToCode());
    }

    [Test]
    public void ToCodeWhenLithuanianTest()
    {
        Assert.AreEqual("lt", Language.Lithuanian.ToCode());
    }

    [Test]
    public void ToCodeWhenLuxembourgishTest()
    {
        Assert.AreEqual("lb", Language.Luxembourgish.ToCode());
    }

    [Test]
    public void ToCodeWhenMacedonianTest()
    {
        Assert.AreEqual("mk", Language.Macedonian.ToCode());
    }

    [Test]
    public void ToCodeWhenMalagasyTest()
    {
        Assert.AreEqual("mg", Language.Malagasy.ToCode());
    }

    [Test]
    public void ToCodeWhenMalayTest()
    {
        Assert.AreEqual("ms", Language.Malay.ToCode());
    }

    [Test]
    public void ToCodeWhenMalayalamTest()
    {
        Assert.AreEqual("ml", Language.Malayalam.ToCode());
    }

    [Test]
    public void ToCodeWhenMalteseTest()
    {
        Assert.AreEqual("mt", Language.Maltese.ToCode());
    }

    [Test]
    public void ToCodeWhenMaoriTest()
    {
        Assert.AreEqual("mi", Language.Maori.ToCode());
    }

    [Test]
    public void ToCodeWhenMarathiTest()
    {
        Assert.AreEqual("mr", Language.Marathi.ToCode());
    }

    [Test]
    public void ToCodeWhenMongolianTest()
    {
        Assert.AreEqual("mn", Language.Mongolian.ToCode());
    }

    [Test]
    public void ToCodeWhenBurmeseTest()
    {
        Assert.AreEqual("my", Language.Burmese.ToCode());
    }

    [Test]
    public void ToCodeWhenNepaliTest()
    {
        Assert.AreEqual("ne", Language.Nepali.ToCode());
    }

    [Test]
    public void ToCodeWhenNorwegianTest()
    {
        Assert.AreEqual("no", Language.Norwegian.ToCode());
    }

    [Test]
    public void ToCodeWhenPashtoTest()
    {
        Assert.AreEqual("ps", Language.Pashto.ToCode());
    }

    [Test]
    public void ToCodeWhenPersianTest()
    {
        Assert.AreEqual("fa", Language.Persian.ToCode());
    }

    [Test]
    public void ToCodeWhenPolishTest()
    {
        Assert.AreEqual("pl", Language.Polish.ToCode());
    }

    [Test]
    public void ToCodeWhenPortugueseTest()
    {
        Assert.AreEqual("pt", Language.Portuguese.ToCode());
    }

    [Test]
    public void ToCodeWhenPunjabiTest()
    {
        Assert.AreEqual("ma", Language.Punjabi.ToCode());
    }

    [Test]
    public void ToCodeWhenRomanianTest()
    {
        Assert.AreEqual("ro", Language.Romanian.ToCode());
    }

    [Test]
    public void ToCodeWhenRussianTest()
    {
        Assert.AreEqual("ru", Language.Russian.ToCode());
    }

    [Test]
    public void ToCodeWhenSamoanTest()
    {
        Assert.AreEqual("sm", Language.Samoan.ToCode());
    }

    [Test]
    public void ToCodeWhenScots_GaelicTest()
    {
        Assert.AreEqual("gd", Language.Scots_Gaelic.ToCode());
    }

    [Test]
    public void ToCodeWhenSerbianTest()
    {
        Assert.AreEqual("sr", Language.Serbian.ToCode());
    }

    [Test]
    public void ToCodeWhenSesothoTest()
    {
        Assert.AreEqual("st", Language.Sesotho.ToCode());
    }

    [Test]
    public void ToCodeWhenShonaTest()
    {
        Assert.AreEqual("sn", Language.Shona.ToCode());
    }

    [Test]
    public void ToCodeWhenSindhiTest()
    {
        Assert.AreEqual("sd", Language.Sindhi.ToCode());
    }

    [Test]
    public void ToCodeWhenSinhalaTest()
    {
        Assert.AreEqual("si", Language.Sinhala.ToCode());
    }

    [Test]
    public void ToCodeWhenSlovakTest()
    {
        Assert.AreEqual("sk", Language.Slovak.ToCode());
    }

    [Test]
    public void ToCodeWhenSlovenianTest()
    {
        Assert.AreEqual("sl", Language.Slovenian.ToCode());
    }

    [Test]
    public void ToCodeWhenSomaliTest()
    {
        Assert.AreEqual("so", Language.Somali.ToCode());
    }

    [Test]
    public void ToCodeWhenSpanishTest()
    {
        Assert.AreEqual("es", Language.Spanish.ToCode());
    }

    [Test]
    public void ToCodeWhenSundaneseTest()
    {
        Assert.AreEqual("su", Language.Sundanese.ToCode());
    }

    [Test]
    public void ToCodeWhenSwahiliTest()
    {
        Assert.AreEqual("sw", Language.Swahili.ToCode());
    }

    [Test]
    public void ToCodeWhenSwedishTest()
    {
        Assert.AreEqual("sv", Language.Swedish.ToCode());
    }

    [Test]
    public void ToCodeWhenTajikTest()
    {
        Assert.AreEqual("tg", Language.Tajik.ToCode());
    }

    [Test]
    public void ToCodeWhenTamilTest()
    {
        Assert.AreEqual("ta", Language.Tamil.ToCode());
    }

    [Test]
    public void ToCodeWhenTeluguTest()
    {
        Assert.AreEqual("te", Language.Telugu.ToCode());
    }

    [Test]
    public void ToCodeWhenThaiTest()
    {
        Assert.AreEqual("th", Language.Thai.ToCode());
    }

    [Test]
    public void ToCodeWhenTurkishTest()
    {
        Assert.AreEqual("tr", Language.Turkish.ToCode());
    }

    [Test]
    public void ToCodeWhenUkrainianTest()
    {
        Assert.AreEqual("uk", Language.Ukrainian.ToCode());
    }

    [Test]
    public void ToCodeWhenUrduTest()
    {
        Assert.AreEqual("ur", Language.Urdu.ToCode());
    }

    [Test]
    public void ToCodeWhenUzbekTest()
    {
        Assert.AreEqual("uz", Language.Uzbek.ToCode());
    }

    [Test]
    public void ToCodeWhenVietnameseTest()
    {
        Assert.AreEqual("vi", Language.Vietnamese.ToCode());
    }

    [Test]
    public void ToCodeWhenWelshTest()
    {
        Assert.AreEqual("cy", Language.Welsh.ToCode());
    }

    [Test]
    public void ToCodeWhenXhosaTest()
    {
        Assert.AreEqual("xh", Language.Xhosa.ToCode());
    }

    [Test]
    public void ToCodeWhenYiddishTest()
    {
        Assert.AreEqual("yi", Language.Yiddish.ToCode());
    }

    [Test]
    public void ToCodeWhenYorubaTest()
    {
        Assert.AreEqual("yo", Language.Yoruba.ToCode());
    }

    [Test]
    public void ToCodeWhenZuluTest()
    {
        Assert.AreEqual("zu", Language.Zulu.ToCode());
    }

    [Test]
    public void ToCodeWhenHebrewOldTest()
    {
        Assert.AreEqual("iw", Language.HebrewOld.ToCode());
    }

    [Test]
    public void ToCodeWhenKinyarwandaTest()
    {
        Assert.AreEqual("rw", Language.Kinyarwanda.ToCode());
    }

    [Test]
    public void ToCodeWhenOdiaTest()
    {
        Assert.AreEqual("or", Language.Odia.ToCode());
    }

    [Test]
    public void ToCodeWhenTatarTest()
    {
        Assert.AreEqual("tt", Language.Tatar.ToCode());
    }

    [Test]
    public void ToCodeWhenTurkmenTest()
    {
        Assert.AreEqual("tk", Language.Turkmen.ToCode());
    }

    [Test]
    public void ToCodeWhenUyghurTest()
    {
        Assert.AreEqual("ug", Language.Uyghur.ToCode());
    }

    [Test]
    public void IsValidNmtWhenAfrikaansTest()
    {
        Assert.IsTrue(Language.Afrikaans.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenAlbanianTest()
    {
        Assert.IsTrue(Language.Albanian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenAmharicTest()
    {
        Assert.IsTrue(Language.Amharic.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenArabicTest()
    {
        Assert.IsTrue(Language.Arabic.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenArmenianTest()
    {
        Assert.IsTrue(Language.Armenian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenAzeerbaijaniTest()
    {
        Assert.IsTrue(Language.Azeerbaijani.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenBasqueTest()
    {
        Assert.IsTrue(Language.Basque.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenBelarusianTest()
    {
        Assert.IsTrue(Language.Belarusian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenBengaliTest()
    {
        Assert.IsTrue(Language.Bengali.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenBosnianTest()
    {
        Assert.IsTrue(Language.Bosnian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenBulgarianTest()
    {
        Assert.IsTrue(Language.Bulgarian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenCatalanTest()
    {
        Assert.IsTrue(Language.Catalan.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenCebuanoTest()
    {
        Assert.IsTrue(Language.Cebuano.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenChichewaTest()
    {
        Assert.IsFalse(Language.Chichewa.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenChinese_SimplifiedTest()
    {
        Assert.IsTrue(Language.Chinese_Simplified.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenChinese_TraditionalTest()
    {
        Assert.IsTrue(Language.Chinese_Traditional.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenCorsicanTest()
    {
        Assert.IsTrue(Language.Corsican.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenCroatianTest()
    {
        Assert.IsTrue(Language.Croatian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenCzechTest()
    {
        Assert.IsTrue(Language.Czech.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenDanishTest()
    {
        Assert.IsTrue(Language.Danish.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenDutchTest()
    {
        Assert.IsTrue(Language.Dutch.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenEnglishTest()
    {
        Assert.IsTrue(Language.English.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenEsperantoTest()
    {
        Assert.IsTrue(Language.Esperanto.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenEstonianTest()
    {
        Assert.IsTrue(Language.Estonian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenFilipinoTest()
    {
        Assert.IsFalse(Language.Filipino.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenFinnishTest()
    {
        Assert.IsTrue(Language.Finnish.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenFrenchTest()
    {
        Assert.IsTrue(Language.French.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenFrisianTest()
    {
        Assert.IsTrue(Language.Frisian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenGalicianTest()
    {
        Assert.IsTrue(Language.Galician.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenGeorgianTest()
    {
        Assert.IsTrue(Language.Georgian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenGermanTest()
    {
        Assert.IsTrue(Language.German.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenGreekTest()
    {
        Assert.IsTrue(Language.Greek.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenGujaratiTest()
    {
        Assert.IsTrue(Language.Gujarati.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenHaitian_CreoleTest()
    {
        Assert.IsTrue(Language.Haitian_Creole.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenHausaTest()
    {
        Assert.IsTrue(Language.Hausa.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenHawaiianTest()
    {
        Assert.IsTrue(Language.Hawaiian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenHebrewTest()
    {
        Assert.IsTrue(Language.Hebrew.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenHebrewOldTest()
    {
        Assert.IsFalse(Language.HebrewOld.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenHindiTest()
    {
        Assert.IsTrue(Language.Hindi.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenHmongTest()
    {
        Assert.IsTrue(Language.Hmong.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenHungarianTest()
    {
        Assert.IsTrue(Language.Hungarian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenIcelandicTest()
    {
        Assert.IsTrue(Language.Icelandic.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenIgboTest()
    {
        Assert.IsTrue(Language.Igbo.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenIndonesianTest()
    {
        Assert.IsTrue(Language.Indonesian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenIrishTest()
    {
        Assert.IsTrue(Language.Irish.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenItalianTest()
    {
        Assert.IsTrue(Language.Italian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenJapaneseTest()
    {
        Assert.IsTrue(Language.Japanese.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenJavaneseTest()
    {
        Assert.IsTrue(Language.Javanese.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenKannadaTest()
    {
        Assert.IsTrue(Language.Kannada.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenKazakhTest()
    {
        Assert.IsTrue(Language.Kazakh.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenKhmerTest()
    {
        Assert.IsTrue(Language.Khmer.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenKoreanTest()
    {
        Assert.IsTrue(Language.Korean.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenKurdishTest()
    {
        Assert.IsTrue(Language.Kurdish.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenKyrgyzTest()
    {
        Assert.IsTrue(Language.Kyrgyz.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenLaoTest()
    {
        Assert.IsTrue(Language.Lao.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenLatinTest()
    {
        Assert.IsTrue(Language.Latin.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenLatvianTest()
    {
        Assert.IsTrue(Language.Latvian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenLithuanianTest()
    {
        Assert.IsTrue(Language.Lithuanian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenLuxembourgishTest()
    {
        Assert.IsTrue(Language.Luxembourgish.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenMacedonianTest()
    {
        Assert.IsTrue(Language.Macedonian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenMalagasyTest()
    {
        Assert.IsTrue(Language.Malagasy.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenMalayTest()
    {
        Assert.IsTrue(Language.Malay.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenMalayalamTest()
    {
        Assert.IsTrue(Language.Malayalam.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenMalteseTest()
    {
        Assert.IsTrue(Language.Maltese.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenMaoriTest()
    {
        Assert.IsTrue(Language.Maori.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenMarathiTest()
    {
        Assert.IsTrue(Language.Marathi.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenMongolianTest()
    {
        Assert.IsTrue(Language.Mongolian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenBurmeseTest()
    {
        Assert.IsTrue(Language.Burmese.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenNepaliTest()
    {
        Assert.IsTrue(Language.Nepali.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenNorwegianTest()
    {
        Assert.IsTrue(Language.Norwegian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenPashtoTest()
    {
        Assert.IsTrue(Language.Pashto.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenPersianTest()
    {
        Assert.IsTrue(Language.Persian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenPolishTest()
    {
        Assert.IsTrue(Language.Polish.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenPortugueseTest()
    {
        Assert.IsTrue(Language.Portuguese.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenPunjabiTest()
    {
        Assert.IsTrue(Language.Punjabi.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenRomanianTest()
    {
        Assert.IsTrue(Language.Romanian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenRussianTest()
    {
        Assert.IsTrue(Language.Russian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSamoanTest()
    {
        Assert.IsTrue(Language.Samoan.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenScots_GaelicTest()
    {
        Assert.IsTrue(Language.Scots_Gaelic.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSerbianTest()
    {
        Assert.IsTrue(Language.Serbian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSesothoTest()
    {
        Assert.IsTrue(Language.Sesotho.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenShonaTest()
    {
        Assert.IsTrue(Language.Shona.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSindhiTest()
    {
        Assert.IsTrue(Language.Sindhi.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSinhalaTest()
    {
        Assert.IsTrue(Language.Sinhala.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSlovakTest()
    {
        Assert.IsTrue(Language.Slovak.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSlovenianTest()
    {
        Assert.IsTrue(Language.Slovenian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSomaliTest()
    {
        Assert.IsTrue(Language.Somali.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSpanishTest()
    {
        Assert.IsTrue(Language.Spanish.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSundaneseTest()
    {
        Assert.IsTrue(Language.Sundanese.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSwahiliTest()
    {
        Assert.IsTrue(Language.Swahili.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenSwedishTest()
    {
        Assert.IsTrue(Language.Swedish.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenTajikTest()
    {
        Assert.IsTrue(Language.Tajik.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenTamilTest()
    {
        Assert.IsTrue(Language.Tamil.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenTeluguTest()
    {
        Assert.IsTrue(Language.Telugu.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenThaiTest()
    {
        Assert.IsTrue(Language.Thai.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenTurkishTest()
    {
        Assert.IsTrue(Language.Turkish.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenUkrainianTest()
    {
        Assert.IsTrue(Language.Ukrainian.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenUrduTest()
    {
        Assert.IsTrue(Language.Urdu.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenUzbekTest()
    {
        Assert.IsTrue(Language.Uzbek.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenVietnameseTest()
    {
        Assert.IsTrue(Language.Vietnamese.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenWelshTest()
    {
        Assert.IsTrue(Language.Welsh.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenXhosaTest()
    {
        Assert.IsTrue(Language.Xhosa.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenYiddishTest()
    {
        Assert.IsTrue(Language.Yiddish.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenYorubaTest()
    {
        Assert.IsTrue(Language.Yoruba.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenZuluTest()
    {
        Assert.IsTrue(Language.Zulu.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenKinyarwandaTest()
    {
        Assert.IsTrue(Language.Kinyarwanda.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenOdiaTest()
    {
        Assert.IsTrue(Language.Odia.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenTatarTest()
    {
        Assert.IsTrue(Language.Tatar.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenTurkmenTest()
    {
        Assert.IsTrue(Language.Turkmen.IsValidNmt());
    }

    [Test]
    public void IsValidNmtWhenUyghurTest()
    {
        Assert.IsTrue(Language.Uyghur.IsValidNmt());
    }
}