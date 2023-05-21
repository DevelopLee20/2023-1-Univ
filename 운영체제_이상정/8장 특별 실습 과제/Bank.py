class Process:
    def __init__(self, Allocation:list, Max:list, Available:list, Request:list) -> None:
        '''프로세스 클래스
        @param self.Available : dim 1, 각 종류의 자원이 몇 개 사용 가능한지 표시
        @param self.Max : dim 2, 각 프로세스가 최대로 필요로하는 자원의 개수
        @param self.Allocation : dim 2, 각 프로세스에 현재 할당된 자원의 개수
        @param self.Need : dim 2, 각 프로세스가 향후 요청할 수 있는 자원의 개수
        @param self.Request : dim 2, 각 프로세스가 요청한 자원의 개수
        @param self.ProcessSize : type int, 프로세스의 개수
        @param self.ResourceSize : type int, 자원의 개수(종류)
        @param self.Request : dim 2, 각 프로세스가 요청한 자원의 개수
        '''
        self.ProcessSize = len(Allocation)
        self.ResourceSize = len(Allocation[0])
        self.Available = Available
        self.Max = Max
        self.Allocation = Allocation
        self.Need = [[0 for _ in range(self.ResourceSize)] for _ in range(self.ProcessSize)]
        self.Request = Request

        for i in range(self.ProcessSize):
            for j in range(self.ResourceSize):
                self.Need[i][j] = self.Max[i][j] - self.Allocation[i][j]

    def SafetyAlgorithm(self) -> bool:
        '''
        안전성 알고리즘(Safety Algorithm)
        안전성 결과에 따라 True, False를 반환한다.
        '''
        # step 1-----------------------------------------------

        # Work = Available로 초기화
        Work = [i for i in self.Available]

        # i=0, 1, ..., n-1에 대해서 Finish[i] = false로 초기화
        Finish = [False for _ in range(self.ProcessSize)]
        Checkout = True

        # 위 조건을 만족하는 i 값을 찾을 수 없다면, step 4로 이동


        while Checkout:
            Checkout = False
            self.ResourceRequestAlgorithm()

            # step 2-------------------------------------------

            # 아래 두 조건을 만족시키는 i값을 탐색
            for i in range(self.ProcessSize):
                # step 2 조건1: Finish[i] == False
                if Finish[i] == False:
                    needs = True
                
                    # step 2 조건2: Need[i] <= Work
                    for j in range(self.ResourceSize):
                        if self.Need[i][j] > Work[j]:
                            needs = False
                            break
                    
                    if needs:
                        Checkout = True

                        # step 3--------------------------------------

                        # Work = Work + Allocation[i], Finish[i] = true
                        for j in range(self.ResourceSize):
                            Work[j] = Work[j] + self.Allocation[i][j]
                            
                        Finish[i] = True
                        print(f"P{i} end")
        
        # step 4--------------------------------------------------

        # 모든 i 값에 대해 Finish[i] == true이면 이 시스템은 안전 상태에 있음
        for i in range(self.ProcessSize):
            if Finish[i] == False:
                print("UnSafe")
                return False
        
        print("Safe")
        return True
    
    def ResourceRequestAlgorithm(self) -> None:
        '''
        자원 요청 알고리즘
        프로세스가 요청한 자원에 따라 할당해주고, 안전한지 SafetyAlgorithm을 통해 확인
        '''

        for i in range(self.ProcessSize):
            # Request가 요청하고 있음을 의미
            if sum(self.Request[i]):
                
                # step 1-----------------------------------
                step1Check = True
                for j in range(self.ResourceSize):
                    if self.Request[i][j] > self.Need[i][j]:
                        step1Check = False
                        
                if step1Check:
                    # step 2-------------------------
                    step2Check = True
                    for j in range(self.ResourceSize):
                        if self.Request[i][j] > self.Available[j]:
                            step2Check = False
                    
                    if step2Check:
                        # step 3------------------------
                        for j in range(self.ResourceSize):
                            self.Available[j] = self.Available[j] - self.Request[i][j]
                            self.Allocation[i][j] = self.Allocation[i][j] + self.Request[i][j]
                            self.Need[i][j] = self.Need[i][j] - self.Request[i][j]

                        # 불안전하다면 원상 복원
                        if self.SafetyAlgorithm_Checker() == False:
                            print("recover")
                            for j in range(self.ResourceSize):
                                self.Available[j] = self.Available[j] - self.Request[i][j]
                                self.Allocation[i][j] = self.Allocation[i][j] + self.Request[i][j]
                                self.Need[i][j] = self.Need[i][j] - self.Request[i][j]

                        else:
                            print("Request Success")
                            for j in range(self.ResourceSize):
                                self.Request[i][j] = 0

                    else:
                        print("p wait")

                else:
                    print("step 1 error")
                    exit()

    def SafetyAlgorithm_Checker(self) -> bool:
        '''
        안전성 알고리즘(Safety Algorithm)으로 ResourceRequestAlgorithm() 에서 복원을 할지 말지 결정 
        '''
        # step 1-----------------------------------------------

        # Work = Available로 초기화
        Work = [i for i in self.Available]

        # i=0, 1, ..., n-1에 대해서 Finish[i] = false로 초기화
        Finish = [False for _ in range(self.ProcessSize)]
        Checkout = True

        # 위 조건을 만족하는 i 값을 찾을 수 없다면, step 4로 이동


        while Checkout: 
            Checkout = False

            # step 2-------------------------------------------

            # 아래 두 조건을 만족시키는 i값을 탐색
            for i in range(self.ProcessSize):
                # step 2 조건1: Finish[i] == False
                if Finish[i] == False:
                    needs = True
                
                    # step 2 조건2: Need[i] <= Work
                    for j in range(self.ResourceSize):
                        if self.Need[i][j] > Work[j]:
                            needs = False
                            break
                    
                    if needs:
                        Checkout = True

                        # step 3--------------------------------------

                        # Work = Work + Allocation[i], Finish[i] = true
                        for j in range(self.ResourceSize):
                            Work[j] = Work[j] + self.Allocation[i][j]
                            
                        Finish[i] = True
        
        # step 4--------------------------------------------------

        # 모든 i 값에 대해 Finish[i] == true이면 이 시스템은 안전 상태에 있음
        for i in range(self.ProcessSize):
            if Finish[i] == False:
                print("Check result: UnSafe")
                return False
        
        print("Check result: Safe")
        return True
                        
if __name__ == "__main__":
    Allocation = [
        [0,0,1,2],
        [1,0,0,0],
        [1,3,5,4],
        [0,6,3,2],
        [0,0,1,4],
    ]

    Max = [
        [0,0,1,2],
        [1,7,5,0],
        [2,3,5,6],
        [0,6,5,2],
        [0,6,5,6],
    ]

    Available = [1,5,2,0]

    Request = [
        [0,0,0,0],
        [0,4,2,0],
        [0,0,0,0],
        [0,0,0,0],
        [0,0,0,0],
    ]

    algo = Process(Allocation, Max, Available, Request)
    algo.SafetyAlgorithm()
    # algo.ResourceRequestAlgorithm()
