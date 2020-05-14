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
| 10              | 0.0769790 s        | 0.0003250 s        |
| 100             | 0.0883400 s        | 0.0003120 s        |
| 1000            | 0.1272300 s         | 0.0003350 s        |
| 10000           | 5.2467400 s         | 0.0007410 s        |

#### Result for PC

| Input size | O(n^2) | O(n)|
|:---------------:|:---------------:|:---------------:|
| 10              | 0.0049772 s        | 0.0001815 s        |
| 100             | 0.0049996 s        | 0.0001880 s        |
| 1000            | 0.0230451 s         | 0.0002055 s        |
| 10000           | 1.6763148 s         | 0.0003264 s        |