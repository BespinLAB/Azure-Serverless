# Azure Serverless
**Azure Functions를 이용하여 Serverless 개념을 이해하고 직접 구현해봅니다.**


## Prerequisites
- [Azure 계정](https://azure.microsoft.com/ko-kr/)
- [Visual Studio Community 2017](https://visualstudio.microsoft.com/ko/thank-you-downloading-visual-studio/?sku=Community&rel=15)
- [Azure Storage Explorer](https://azure.microsoft.com/ko-kr/features/storage-explorer/)
- [Postman](https://www.getpostman.com/)
- [Node.js](https://nodejs.org/en/download/)


## Contents
- [Intro](#intro)
- [Chapter1](#chapter1)
- [Chapter2](#chapter2)
- [Chapter3](#chapter3)
- [Chapter4](#chapter4)
- [Chapter5](#chapter5)
- [Chapter6](#chapter6)
- [Chapter7](#chapter7)
    
    
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
[Youtube](https://www.youtube.com/playlist?list=PLoZOyjmMkw9nt6a3zgjFSSyATHHEThZUH)<br>
Functions와 Logic Apps로 다양한 서비스를 구현합니다.

    - Azure Cognitive와 연동하여 인물의 성별과 나이 예측
    - Http request를 받아 Azure SQL Server에 저장
    - Onedrive에 파일이 추가되면 Blob storage에 저장
    - Logic Apps로 트위터 모니터링하여 Gmail로 발송
    - Logic Apps와 Functions로 트위터에 새 글이 올라오면 SendGrid로 메일 발송

![](/data/chapter03.png)

### Chapter4
[Youtube](https://www.youtube.com/playlist?list=PLoZOyjmMkw9nnmbSqH_GoVj_JlQdhvOyz)<br>
Visual Studio에서 Functions를 구현합니다.

    - Visual Studio 2017에서 Function app 생성
    - 로컬 환경에서 Azure Functions 구현
    - 로컬 환경에서 Azure Storage 연결
    - Visual Studio를 사용하여 Azure로 Functions 배포
    - Visual Studio로 Azure 상의 Functions를 개발

![](/data/chapter04.png)

### Chapter5
[Youtube](https://www.youtube.com/playlist?list=PLoZOyjmMkw9mQz2Bqk7WolLZIahqm9Pun)<br>
Azure Functions의 다양한 Test 방법을 수행합니다.

    - Trigger 작동 확인 (Http, Blob, Queue)
    - Staging 환경 구성하고 Swap 기능 사용
    - Visual Studio Team Service에서 부하 테스트 진행
    - Local 환경에서 Azure CLI로 Functions 생성하고 테스트
    - Application Insight로 Functions 작동 확인

![](/data/chapter05.png)

### Chapter6
[Youtube](https://www.youtube.com/playlist?list=PLoZOyjmMkw9ksReXcg0m0XsAyKEbZhpjr)<br>
Azure Functions를 Monitoring 합니다.

    - Functions 자체 기능을 활용하여 모니터링
    - Application Insight를 사용하여 Functions 모니터링
    - Application Insight Function을 사용하여 Custom Metric 구성
    - Application Insight Function을 사용하여 일일 모니터링 보고서 발송
    - Application Insight Function을 사용하여 PowerBI와 연계

![](/data/chapter06.png)

### Chapter7
[Youtube](https://www.youtube.com/playlist?list=PLoZOyjmMkw9lfKgxe1nah1nJ73juhWvWj)<br>
코드 재사용성을 높이기 위해 Azure Functions를 Refactoring 합니다.

    - 다른 Function에서 호출할 수 있는 Shared Class 생성
    - Visual Studio에서 Build한 dll 파일 호출하여 활용
    - Visual Studio에서 Build한 exe 파일 호출하여 활용

![](/data/chapter07.png)