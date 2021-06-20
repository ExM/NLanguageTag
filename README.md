# LanguageTag
Language tags are used to help identify languages, whether spoken, written, signed, or otherwise signaled, for the purpose of communication. Language tag syntax is defined by the IETF's BCP 47

This library implements all subtags from the [BCP47](http://www.w3.org/International/articles/bcp47) specification.
Subtag enumerations are generated using code generation from the [IANA Language Subtag Registry](http://www.iana.org/assignments/language-subtag-registry/language-subtag-registry).
Updating the subtag registry does not break the backward binary compatibility of this library. 

[![NuGet Version](http://img.shields.io/nuget/v/NLanguageTag.svg?style=flat)](https://www.nuget.org/packages/NLanguageTag/) 
[![NuGet Downloads](http://img.shields.io/nuget/dt/NLanguageTag.svg?style=flat)](https://www.nuget.org/packages/NLanguageTag/)

## Usage
-----

**Fields of LanguageTag**

* `Language` - The primary language subtag is the first subtag in a language tag
* `Script` - Script subtags are used to indicate the script or writing system variations that distinguish the written forms of a language or its dialects
* `Region` - Region subtags are used to indicate linguistic variations associated with or appropriate to a specific country, territory, or region.
* `Variants` - Variant subtags are used to indicate additional, well-recognized variations that define a language or its dialects that are not covered by other available subtags.
* `Extensions` - Extensions provide a mechanism for extending language tags for use in various applications.
* `PrivateUse` - Private use subtags are used to indicate distinctions in language that are important in a given context by private agreement.

**Initialize**

```C#
var en = Language.EN; // English language
var zh = Language.ZH; // Chinese language

var latn = Script.Latn; // Latin script
var hans = Script.Hans; // Han (Simplified variant)

var tw = Region.TW; // Taiwan, Province of China

// tag zh-Hans-TW
var tag1 = new LanguageTag(zh, hans, tw);

// tag zh-Latn-TW-Pinyin
var tag2 = new LanguageTag(zh, latn, tw, new []{ Variant.Pinyin });

// tag en-US-x-twain
var tag3 = new LanguageTag(en, Region.US, ExtensionSubtag.ForPrivateUse("twain"));

// tag de-DE-u-co-phonebk
var tag4 = new LanguageTag(
	Language.DE,
	Region.DE,
	new []{ new ExtensionSubtag('u', "co", "phonebk") });
```

**Parsing**

```C#
var tag3 = LanguageTag.Parse("ru");
var tag4 = LanguageTag.Parse("zh-Hans-TW");
var tag5 = LanguageTag.Parse("en-GB-scotland");
```

**Any operation**

```C#
// Equals
Assert.True(tag1 == tag6);

// zh-Hans-TW -> zh-Hans
var tag8 = tag6.Take(LanguageTag.Field.Language | LanguageTag.Field.Script);

// zh-Hans is subset of zh-Hans-TW
Assert.True(tag8.IsSubsetOf(tag6));
```

## Links to main documentation 
* Tags for Identifying Languages: https://tools.ietf.org/html/bcp47 (http://www.rfc-editor.org/rfc/bcp/bcp47.txt)
* Language tags in HTML and XML: http://www.w3.org/International/articles/language-tags
* Choosing a Language Tag: http://www.w3.org/International/questions/qa-choosing-language-tags
* Understanding the New Language Tags: http://www.w3.org/International/articles/bcp47
* IANA Language Subtag Registry: http://www.iana.org/assignments/language-subtag-registry/language-subtag-registry                       

## Development
Generate source code by saved language-subtag-registry
```
dotnet run -p ./SourceCodeRenderer/SourceCodeRenderer.csproj -- -i./DataSources -o./NLanguageTag/Generated
```

Update language-subtag-registry and generate source code
```
dotnet run -p ./SourceCodeRenderer/SourceCodeRenderer.csproj -- -un -i./DataSources -o./NLanguageTag/Generated
```

