![Emotion](Docs/Images/Emotion.png)

# Emotion API: .NET Core Client Library & Sample

| Branch      | Build Status  |
| ----------- | ------------- |
| develop     | [![Build Status](https://travis-ci.org/Microsoft/Cognitive-Emotion-DotNetCore.svg?branch=develop)](https://travis-ci.org/Microsoft/Cognitive-Emotion-DotNetCore) |
| master      | [![Build Status](https://travis-ci.org/Microsoft/Cognitive-Emotion-DotNetCore.svg?branch=master)](https://travis-ci.org/Microsoft/Cognitive-Emotion-DotNetCore) |

## Overview
The Emotion API takes an image as an input, and returns the confidence across a set of emotions for each face in the image, as well as bounding box for the face, from the Face API. The emotions detected are happiness, sadness, surprise, anger, fear, contempt, disgust or neutral. These emotions are communicated cross-culturally and universally via the same basic facial expressions, where are identified by Emotion API.

This repository contains the .NET Core SDK and sample application that allow you to enter your API key and specify an image to detect emotion in.

Before you can use the SDK or run the sample application you must subscribe to the Emotion API which is part of Microsoft Cognitive Services. You can learn how to subscribe [here](https://www.microsoft.com/cognitive-services/en-us/sign-up).

## The Client Library
The client library is a thin .NET Core client wrapper for the Emotion API. The easiest way to use this client library is to get the microsoft.projectxoford.emotion.dotnetcore package from nuget. Please go to the [.NET Core Emotion API Package in Nuget](https://www.nuget.org/packages/Microsoft.ProjectOxford.Emotion.DotNetCore/) for more details.

## Contributing
Contributions are welcome. Feel free to file issues and pull requests on the repo and we'll address them as we can. Learn more about how you can help on our [Contribution Rules & Guidelines](/CONTRIBUTING.md).

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## License
All Microsoft Cognitive Services SDKs and samples are licensed with the MIT License. For more details, see [LICENSE](/LICENSE.md).

## Developer Code of Conduct
Developers using this project are expected to follow the “Developer Code of Conduct for Microsoft Cognitive Services” at [http://go.microsoft.com/fwlink/?LinkId=698895](http://go.microsoft.com/fwlink/?LinkId=698895).

## Disclaimer
The image, voice, video or text understanding capabilities of Microsoft.ProjectOxford.Emotion.DotNetCore use Microsoft Cognitive Services. Microsoft will receive the images, audio, video, and other data that you upload (via this app) for service improvement purposes.

## Report Abuse
To report abuse of the Microsoft Cognitive Services to Microsoft, please visit the Microsoft Cognitive Services website at [https://www.microsoft.com/cognitive-services](https://www.microsoft.com/cognitive-services), and use the "Report Abuse" link at the bottom of the page to contact Microsoft.

## Privacy Policy
For more information about Microsoft privacy policies please see their privacy statement here: [https://go.microsoft.com/fwlink/?LinkId=521839](https://go.microsoft.com/fwlink/?LinkId=521839).
