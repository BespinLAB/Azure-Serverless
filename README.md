# Azure Serverless
**Azure Functions를 이용하여 Serverless 개념을 이해하고 직접 구현해봅니다.**

- [Prerequisites](#prerequisites)
- [Contents](#contents)
    - [Intro](#intro)
    - [Chapter1](#chapter1)
    - [Chapter2](#chapter2)
    - [Chapter3](#chapter3)


## Prerequisites
- [Azure 계정](https://azure.microsoft.com/ko-kr/)
- [Visual Studio Community 2017](https://visualstudio.microsoft.com/ko/thank-you-downloading-visual-studio/?sku=Community&rel=15)
- [Azure Storage Explorer](https://azure.microsoft.com/ko-kr/features/storage-explorer/)

## Contents

### Intro
[Youtube](https://goo.gl/LFpWtC)

    - Serverless Intro
    - Azure Functions
    - Azure Functions 생성

### Chapter1
[Youtube](https://goo.gl/cUvQ2g)<br>
사용자를 등록하는 기능을 구현합니다.

    - HTTP Trigger 생성
    - HTTP Trigger와 Table Storage 연결
    - HTTP Trigger와 Queue Storage 연결
    - Queue Trigger 만들고 Blob Storage와 연결
    - Image resizer로 이미지 수정

![](/data/chapter01.PNG)

### Chapter2
[Youtube](https://www.youtube.com/playlist?list=PLoZOyjmMkw9luSZZrF0EMaopZJWjkjFv2)<br>
외부 서비스와 연동하여 메일과 SMS를 발송합니다.

    - Sendgrid 서비스와 연동하여 관리자 알림 메일 구현
    - 사용자에게 알림 메일 발송
    - Blob storage에 발송 로그 생성
    - 첨부파일 추가하여 메일 발송
    - Twilio 서비스와 연동하여 사용자에게 SMS 발송

![](/data/chapter02.PNG)

### Chapter3
[Youtube](https://)<br>
Functions와 Logic Apps로 다양한 서비스를 구현합니다.

    - Azure Cognitive와 연동하여 인물의 성별과 나이 예측
    - Http request를 받아 Azure SQL Server에 저장
    - Onedrive에 파일이 추가되면 Blob storage에 저장
    - Logic Apps로 트위터 모니터링하여 Gmail로 발송
    - Logic Apps와 Functions로 트위터에 새 글이 올라오면 SendGrid로 메일 발송

![](/data/chapter03.png)
