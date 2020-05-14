# It's all about the speed

Ran this test on two of my machines.

**Macbook Air (mid 2012)**
* i5 @ 1.7 GHz (2 cores)
* 4 GB of memory

**PC (built 2017)**
* i5 @ 5.0 GHz (4 cores)
* 16 GB of memory

#### Result for Macbook Air

| Input size | O(n^2) | O(n)|
|:---------------:|:---------------:|:---------------:|
| 10              | 0.0791 s        | 0.0642 s        |
| 100             | 0.0686 s        | 0.0697 s        |
| 1000            | 0.132 s         | 0.0627 s        |
| 10000           | 2.7142 s         | 0.0682 s        |

#### Result for PC

| Input size | O(n^2) | O(n)|
|:---------------:|:---------------:|:---------------:|
| 10              | 0.0049 s        | 0.0049 s        |
| 100             | 0.0051 s        | 0.0050 s        |
| 1000            | 0.0145 s         | 0.00491 s        |
| 10000           | 0.8280 s         | 0.0053 s        |