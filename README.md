# 📘 1주차 과제: 나만의 디지털 명함 제작

- 이름: 장상 (23017078)
- 학과: 지능형SW융합대학 - 컴퓨터학부 - 컴퓨터SW

## 📌 핵심 기능
- '배경색 랜덤 변경' 버튼 클릭 시 배경색 랜덤 변경
- 'GitHub' 버튼 클릭 시 본인 GitHub 주소로 이동
- '사진 변경' 버튼 클릭 시 사진 변경
- 사진 위에 마우스를 올릴 시 사진의 경계선 스타일 변경

---

## 📷 실행 화면
- (배경색 랜덤 변경)
<p>
<img width="1218" height="824" alt="스크린샷 2026-03-07 211936" src="https://github.com/user-attachments/assets/2a2082ac-d74d-497a-bf88-6f91b7103ba6" />
</p>

- (GitHub 버튼 클릭)
 <p>
 <img width="579" height="357" alt="스크린샷 2026-03-07 223322" src="https://github.com/user-attachments/assets/d29b821d-3aca-4ada-bd88-bbb083906b44" />
 </p>

- (사진 변경)
<p>
<img width="1217" height="821" alt="스크린샷 2026-03-07 205849" src="https://github.com/user-attachments/assets/53d5179a-9c99-47a1-8fbb-acb6577ced4d" />
</p>

- (사진 경계선 변경)

<img width="1217" height="819" alt="스크린샷 2026-03-07 205816" src="https://github.com/user-attachments/assets/8b05bcb5-46c3-422d-b676-ca106d3f4ad1" />

---

## 🛠 구현 시 어려웠던 점
1️⃣ GitHub 주소 추가 코드 작성할 때, 'System.Diagnostics.Process.Start("GitHub 주소");' 코드를 넣었더니 '사용자가 처리 않은 예외' 문구가 떠서 당황했었다.<br>
찾아보니 이 코드는 예전 .NET Framework에서는 잘 되는 경우가 많지만, WinForms + .NET 5/6/7/8 환경에서는 예외가 뜰 수 있다는 것을 알았다.<br>
그래서 새롭게 찾은 코드가<br>
```csharp
 Process.Start(new ProcessStartInfo
 {
     FileName = "GitHub 주소",
     UseShellExecute = true
 });
```
이였다.<br>
최신 .NET에서는 URL을 실행 파일처럼 직접 열려고 하다가 실패하는 경우가 있다고 한다.<br>
그래서 UseShellExecute = true를 넣어서 윈도우가 기본 브라우저로 열게 만들면 정상 작동된다는 것을 새롭게 알았다.

&nbsp;

2️⃣ 사진 변경 시, 변경할 사진을 추가하는 부분도 꽤 헤맸었다.<br>
나는 처음에 pictureBox1.Image = Properties.Resources.다른이미지이름; 코드에 있는 '다른이미지이름' 부분에 그냥 사진을 복사 붙여넣기 하면 되는 줄 알았다.<br>
하지만 되지 않았고, 코드를 쓰려면 현재 내가 작업하고 있는 프로젝트에 Resources.resx를 열어 이미지를 추가해야 한다는 것을 알게 되었다.<br>
<p>
<img width="900" height="482" alt="스크린샷 2026-03-07 214912" src="https://github.com/user-attachments/assets/f856e3f6-f641-4fc6-92aa-40ef5f07c014" />
</p>

&nbsp;

3️⃣ 마우스 이벤트를 추가하는 것 또한 시간을 많이 들었다.<br>
C# 작업이 처음이다 보니 '이벤트 아이콘'이 어떻게 생겼는지, 존재 하는지도 몰랐었다.<br>
사진 속성에서 ⚡번개 아이콘(이벤트)을 클릭 해 목록에서 MouseEnter를 찾아 pictureBox1_MouseEnter로 설정한 후<br>
pictureBox1.BorderStyle = BorderStyle.Fixed3D; 코드를 넣으면 내가 원하는 결과를 얻을 수 있었다.<br>
<img width="519" height="576" alt="스크린샷 2026-03-07 215333" src="https://github.com/user-attachments/assets/7012eaf2-c0ce-47b9-8a07-34b592dae375" />

---
