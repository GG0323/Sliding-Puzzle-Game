# C# 슬라이딩 숫자 퍼즐 게임<br>
- 2학년 2학기 C# 교과목 개인 프로젝트
  
---

## 프로그램 소개
이 프로젝트는 숫자 타일을 빈 칸으로 이동시키며 순서를 맞추는 **슬라이딩 퍼즐 게임** 입니다.   
초보(3×3), 중수(4×4), 고수(5×5) 총 3가지 난이도를 제공하며,   
플레이어가 퍼즐을 얼마나 빠르게 해결하는지를 타이머로 측정해 랭킹으로 기록합니다.   
<br>
회원가입 없이 바로 게임을 즐길 수 있으며,   
순위권에 진입한 경우 **닉네임 + 비밀번호** 를 입력해 기록을 저장할 수 있습니다.
비밀번호를 통해 본인 기록을 인증하고 삭제할 수 있습니다.

---
### 난이도 선택 후 게임 시작 또는 랭킹 리스트 보기
<img width="550" alt="{D7689521-626C-4618-B968-953F55A50C12}" src="https://github.com/user-attachments/assets/58f20a13-63d2-43fb-8998-7735e2b74da2" /><br><br>

---

### 게임 시작
- 별 버튼을 누르면 숫자가 랜덤으로 섞이고 타이머가 흘러갑니다.<br><br>
<img width="400" src="https://github.com/user-attachments/assets/64761738-f3a7-47f4-a677-24cecafdf14c" /><br>
<img width="300" src="https://github.com/user-attachments/assets/ea08e252-f933-4c25-9915-757fe3456df1" />
<img width="300" src="https://github.com/user-attachments/assets/d3eb2aae-c2f1-453b-af9f-8ffd05108843" />
<br><br>

---
### 다 맞췄을 경우
- 1~5위 순위권에 안에 들었을 때   
  - 닉네임과 비밀번호를 입력받아 파일에 저장됩니다.   
  - 닉네임은 중복을 허용하지 않습니다.<br><br>
<img width="400" alt="{53FE33FD-003C-4E14-B269-24237B04CA65}" src="https://github.com/user-attachments/assets/77f0e0bd-5b2b-4b7a-a48b-70d2aeb5caf2" /><br>
<img height="230" alt="{24C8D2D8-5A42-429B-9066-B41ECEB6EE06}" src="https://github.com/user-attachments/assets/aad07950-5054-45a7-99f5-0da3c8e18d2e" />
<img height="230" alt="{98CAF18E-4733-44E0-862B-70D832EA2AEB}" src="https://github.com/user-attachments/assets/0564300e-734b-4160-9952-da9891a80627" />
<br><br>

- 순위권에 못 들었을 때<br><br>
  <img width="400"  alt="{69CBE5CC-4658-4166-8B40-D3B3DB3BCB4C}" src="https://github.com/user-attachments/assets/5b16eba5-e0a3-422c-ab4d-a722cf4f483f" />
<br><br>
---

### 난이도별 랭킹 리스트 확인<br><br>
- 초보 랭킹 순위<br>
  <img width="500" alt="{04831403-E6B8-41D8-98AD-1FA012B3716B}" src="https://github.com/user-attachments/assets/5bdf8da3-9276-4ea9-adb3-0fe28a02fda6" />
  <img width="300" alt="{9BB56B47-BCD1-427D-AC94-8D0188B61EBA}" src="https://github.com/user-attachments/assets/1607105e-b3dc-476e-848c-c8acf46c4e03" /><br><br>
- 중수 랭킹 순위<br>
  <img width="500" alt="{03C56F74-F41F-4DC8-BF5E-F993005337FF}" src="https://github.com/user-attachments/assets/e3373bc8-3201-448f-bbfe-0ff640dcdc06" />
  <img width="300" alt="{BAC035BF-3E2B-4708-B0EF-60454A81CC95}" src="https://github.com/user-attachments/assets/d9d214a3-1a02-424c-a27d-49ac02621221" /><br><br>
- 고수 랭킹 순위<br>
  <img width="500" alt="{8ED643CA-F637-4327-AF02-6C75E1DA0928}" src="https://github.com/user-attachments/assets/7f4efad3-48c3-4bac-999c-5b9f2adabc61" />
  <img width="300" alt="{B79C5E9C-03A4-4CC8-A450-62246450F966}" src="https://github.com/user-attachments/assets/8432bd94-68eb-42e0-9701-22e19a27e79a" /><br><br>
<br><br>

---

### 랭킹 리스트 삭제<br><br>
- 본인 인증을 위한 password 입력<br>
  <img width="400" alt="{26033E27-AA5E-493B-965F-EAFAE48CC918}" src="https://github.com/user-attachments/assets/24298675-599b-4a02-b192-6e25042e223d" /><br><br>
- password 틀렸을 경우<br>
  <img width="400" alt="{0EAABD3F-7562-431E-8045-9C12BC573A10}" src="https://github.com/user-attachments/assets/77a003b0-7429-4f77-a5d3-2ea1a1b22f16" /><br><br>
- password 맞은 경우<br>
  <img width="400" alt="{7F1E526C-B195-4091-B36B-CE8165BD8A50}" src="https://github.com/user-attachments/assets/f5cb83e0-69f9-401f-a19d-2a7a966a9f13" />
  <img width="200" alt="{6C6F770F-9771-4919-BA40-050B11D9AA05}" src="https://github.com/user-attachments/assets/c1579ed0-6a5d-4fc4-96b7-40181998ae8a" /><br><br>
- 삭제 결과<br>
  <img width="500" alt="{F4756D5B-0FC2-46BA-88FD-D068352400A3}" src="https://github.com/user-attachments/assets/bca36a2f-2127-4a23-9a1e-998df8c99a9b" />
  <img width="300" alt="{1D6EAA44-49EA-4960-84BD-0644AD281B08}" src="https://github.com/user-attachments/assets/3815f4cf-dc36-43c4-96ea-8743f222898e" />

