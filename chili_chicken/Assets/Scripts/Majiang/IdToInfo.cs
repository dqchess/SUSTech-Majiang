﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdToInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    private static Dictionary<int, CourseInfo> courses = new Dictionary<int, CourseInfo>()
    {
		//CourseInfo of CS
        {21, new CourseInfo("离散数学（计）", "离散数学是数学与计算机之间的桥梁，在这里，你几乎可以学到今后编程生涯所需要的一切数学基础", "我要是学得会数学，我学什么计算机，很多同学如是说。") },
        {22, new CourseInfo("计算机组成原理", "在这里，你将学会从零开始组装电脑的一切理论知识，课程最后的project甚至需要做出一个CPU（虽然你很大概率仍然不会修电脑。。。", "体验很好，明年会再来的") },
        {23, new CourseInfo("数据结构", "计算机系第一门真正意义上的硬课，在这里你将受到最严酷的磨练，打下未来编程生活的基石，数据结构绝对不是一门轻松的课程", "让我们红橙作伴，活得潇潇洒洒") },
        {24, new CourseInfo("算法分析", "数据结构的后续课程，对于经历了数据结构洗礼的同学来说会轻松很多，但更加侧重算法设计思路", "I'm not here to fail you. 老师诚不欺我") },
        {25, new CourseInfo("数字逻辑", "这是你在计算机系接触硬件的第一节课，在这里你将学习应用数字电路进行数字系统逻辑设计，对于有志学习硬件的同学来说，这门课不容错过", "硬件苦手，还是高级语言适合我，某菜鸡如是说") },
        {26, new CourseInfo("数据库系统原理", "大数据时代，如何优雅地存储海量的数据，如何自如地在数据之海里冲浪而不翻船，一切答案尽在数据库系统原理", "sudo rm -rf /*    \n(╯‵□′)╯︵┻━┻") },
        {27, new CourseInfo("C与C++", "南科大除Java外唯一开设的一门编程语言课程，虽然是选修，但几乎所有的计系学子都会选择这门课（c++是世界上最好的编程语言×", "C++写数据结构和算法分析是真的快乐，体验非常好，建议配合数据结构一同学习——某不愿透露姓名的计系学子") },
        {28, new CourseInfo("计算机系统设计及应用", "虽然看上去很厉害，实际上就是Java2，在这里你能学到更多Java的高级性能，想要选择Java作为主力编程语言的同学们推荐学习。", "这门课可轻松了，就是头顶有点凉") },
        {29, new CourseInfo("计算机与头发保养艺术", "每个计系学子的必修课，虽然没有正式编制，但重要性不言而喻，睿智，恬淡，懂得生活，这才是SUSTech的学生。", "我养生的秘诀就是天天写作业，写作业，写作业，所以，你看我现在快20岁了，精神还是很好——匿了匿了") },

        {31, new CourseInfo("嵌入式系统与微机原理", "带你领略你从未见过的C语言的全新版本，你将体验到C语言平时不会使用的硬件部分", "Again, I am not here to fail you. It should be easy.") },
        {32, new CourseInfo("人工智能", "人工智能的入门课，虽然不够深入，但几乎涵盖了所有你应该了解的领域，非常全面，课程涵盖4个project，包括经典的智能五子棋", "还是玄学神经网络适合我，人工智能的本质绝大多数情况下都是人类智能，有多少人工，就有多少智能。。。") },
        {33, new CourseInfo("计算机网络", "内容覆盖计算机网络的很多方面，从软件层面层层深入到底层硬件，从此网络对你而言再也不是一个黑箱了", "计算机网络很轻松的，真的，不。。。") },
        {34, new CourseInfo("面向对象分析与设计", "你将学到面向对象编程这种强大的编程思想，并且有机会做出大学生涯最拿得出手的一个项目（从此过上拥有对象的生活×", "非常硬核的计算机核心课，可以学到很多知识，推荐指数五颗星") },
        {35, new CourseInfo("操作系统", "和数据结构相同量级的硬核课程，需要花费大量时间来完成这门课程，但与此同时，你能够深刻地理解操作系统的底层原理和实现。", "难顶，非常难顶，学的时候都要自闭了，但是现在看来还是很有收获的") },
        {36, new CourseInfo("软件工程", "面向对象编程的后继课程，进一步学习如何优雅正确地开发大型软件，这次，与面向对象的PC端应用不同，你需要着手开发安卓应用", "经历过面向对象的洗礼后，感觉学起来很轻松，课程不是很肝") },
        {37, new CourseInfo("机器学习", "介绍当今热门的机器学习的底层知识，核心放在Know why,放在证明算法的可行性，而不是Know how, 而不是写一点代码让机器自己学习，本来是面向研究生的课程，但不知道为什么有很多本科生选这门课", "数学，真的是太难了。。。") },
        {38, new CourseInfo("计算机图形学", "内容包括如何再计算机中表示图形、以及利用计算机进行图形的计算、处理和显示的相关原理和算法，很多同学选这门课的目的都是想要学习怎么制作游戏", "高等线性代数体验很好，明年。。。啊，原来是计算机图形学呀") },
        {39, new CourseInfo("计算机视觉", "研究如何使计算机“看”，关注于图形处理，识别，你将学习到如何利用强大的神经网络来解决这些问题", "为什么我的神经网络会觉得这么可爱的白猫是一只狗呢？想不通") },

        //CourseInfo of FIN
        {41, new CourseInfo("微观经济学", "研究社会中单个经济单位的经济行为，以及相应的经济变量的单项数值如何决定的经济学说，你将通过学习这门课来初步进入经济学的世界", "学了微观经济学，买菜的时候就知道怎么砍价了呢") },
        {42, new CourseInfo("宏观经济学", "研究一国经济总量、总需求与总供给、国民收入总量及构成、货币与财政、人口与就业、经济周期与经济增长、国际贸易与国际经济等宏观经济现象", "微观经济是靠无形的手(市场)去干预经济,宏观经济靠有形的手(政府)干预经济") },
        {43, new CourseInfo("财务会计", "现代企业的一项重要的基础性工作，通过一系列会计程序，提供决策有用的信息，并积极参与经营管理决策，提高企业经济效益，服务于市场经济的健康有序发展", "万丈高楼平地起，创业的第一步是学会算账") },
        {44, new CourseInfo("公司金融", "金融学的分支学科，用於考察公司如何有效地利用各种融资渠道，获得最低成本的资金来源，并形成合适的资本结构", "借我一只鸡，还你一窝蛋") },
        {45, new CourseInfo("金融与创业前沿论坛", "邀请金融各界大佬人士为我校学子开设讲座，了解当下金融态势与资本走向，为我们将来进入行业起到指引作用", "站在巨人的肩膀上，事半功倍；你的传奇，由我来复制。") },
        {46, new CourseInfo("商业银行", "涵盖风险管理、商业银行运营、经济资本、监管资本、信用风险识别与计量、信贷业务风险控制等内容，带你深入了解商业银行的性质与职能", "$_$") },
        {47, new CourseInfo("金融市场与金融机构", "系统介绍了各种金融工具、金融交易方式以及各类金融机构，采用大量的真实案例，理论联系实际，既具有理论价值，对金融专业学生未来从业操作又具有宝贵的指导作用", "是你未来从事金融工作的参考书") },
        {48, new CourseInfo("创业金融", "运用现代思想讲解新企业如何在估值、实物期权和经济合约方面制定决策，也运用仿真和特定分析实例解决不确定性问题，包括创建企业、战略和商业计划的财务方面等内容", "企业家、天使投资人和创业投资人都会学，你就是下一个") },
        {49, new CourseInfo("货币银行学", "介绍了国内外金融理论和实践的最新动态，突出对金融学基本知识、基本理论的介绍和基本管理技能的传授", "条理清晰、结构分明、由浅入深、层层推进，你值得拥有") },

        {51, new CourseInfo("金融投资概论", "研究金融投资的相关知识，包含同业拆借、票据贴现市场、短期证券市场、国库券市场、大额存单市场、债券发行与流通市场等内容", "了解金融投资业的基础课") },
        {52, new CourseInfo("计量经济学", "以一定的经济理论和统计资料为基础，运用数学、统计学方法与电脑技术，以建立经济计量模型为主要手段，定量分析研究具有随机性特性的经济变量关系", "是计量（liàng），不是计量（liáng）") },
        {53, new CourseInfo("金融衍生品", "研究金融衍生产品的基本概念与性质，包含远期合约及其定价、期货合约及其定价、期货合约的套期保值策略、互换合约及其定价、期权合约及其策略等内容", "你以为我是一种产品，其实我还是一门课哒") },
        {54, new CourseInfo("金融实证分析方法", "研究金融计算的基本原理和方法，通过动手实验提升金融计算的能力，培养学生用数据说话的概念", "学会使用R软件，事半功倍") },
        {55, new CourseInfo("固定收益产品", "研究固定收益产品的基本概念和性质，包含规避风险、理财策略等内容", "好好学就完事了") },
        {56, new CourseInfo("金融经济学", "研究金融资源有效配置的科学", "核心课程之一，需要下功夫去琢磨") },
        {57, new CourseInfo("投资银行", "本课程介绍投资银行的组织、功能与业务。课程将包括：投行文化与情商教育，客户管理与市场营销，投行与财务顾问，交易与销售，投资与资产管理，投行的风险管理", "$_$ $_$ $_$ $_$ $_$") },
        {58, new CourseInfo("行为经济学", "将行为分析理论与经济运行规律、心理学与经济科学有机结合起来，是很实用的经济学", "行为经济学 = 经济学 + 心理学 + 社会学") },
        {59, new CourseInfo("量化投资分析", "将介绍量化投资的基本框架和理论以及相关的数量工具，并熟悉金融市场数据并且应用所学理论进行量化投资", "用计算机来帮你处理数据，两个方向的交叉") },
        
        //CourseInfo of MATH
        {61, new CourseInfo("概率论与数理统计", "主要研究概率与统计的基本理论、方法与技巧，虽然是数学系开的课程，但是是为工科学生开设的，数学系的学生并不学", "计系专业课都太硬核了，好怀念当初学概统的日子———某计系菜鸡如是说") },
        {62, new CourseInfo("常微分方程", "研究常微分方程中最基本的理论和方法，并将以大量的例子来介绍常微分方程在物理、化学、生物等其他学科中的应用，注重培养学生用常微分方程解决应用问题的意识和能力", "数学专业的重要基础课之一") },
        {63, new CourseInfo("复变函数", "主要讲授复变函数基本理论，内容包括全纯函数、柯西定理及其应用、亚纯函数、级数、留数、对数、整函数、共形映射等", "以复数为自变量的函数，确实不简单") },
        {64, new CourseInfo("初等数论", "是数学类学生的一门重要基础理论课程，遵循少而精的原则，精心选材，对重点内容多侧面分析，为后续课程的学习奠定必要基础，同时培养学生的抽象思维能力和逻辑推理能力", "呜呜呜，数论杀我。。TAT") },
        {65, new CourseInfo("抽象代数", "又叫近世代数，是代数的分支之一，并且与几乎所有的数学分支都有着紧密的联系，是数学和应用数学等学科的必修课，也推荐给计算机科学，物理，化学等专业的学生学习", "初等代数进阶版") },
        {66, new CourseInfo("离散数学（数）", "数学系开设的离散数学，内容更广更深，旨在为计算机科学与技术的研究和应用提供形式化的方法，为实际问题的描述提供数学模型", "计系的离散数学就已经虐死人了，数学系的。。。。") },
        {67, new CourseInfo("应用随机过程", "讲解随机过程的基本概念，并重点叙述几种最重要的随机过程及其应用", "概率论与数理统计进阶版") },
        {68, new CourseInfo("大数据金融", "数学系开设的偏金融方向的专业选修课程，初步了解大数据与金融业的联系与应用", "学一学换换脑子挺不错") },
        {69, new CourseInfo("数分精讲", "衔接高等数学与后期数学课程（如复变函数、实变函数、泛函分析和概率论等）的桥梁，数学系的重要基础课之一", "躲得过初一（数分3），躲不过十五（数分精讲），该来的总会来~") },

        {71, new CourseInfo("实变函数论", "本课程旨在进一步锻炼学生抽象分析的能力，为学生学习后续数学课程奠定基础", "话不多说，谁学谁知道QAQ") },
        {72, new CourseInfo("偏微分方程", "学习研究现代椭圆与抛物偏微分方程理论中的基本概念、基本理论以及基本方法。此课将为学生们以后阅读参考文献和开展相关的科研工作打好基础", "推荐工科学生也学一学喔") },
        {73, new CourseInfo("泛函分析", "本科泛函分析的入门课程，旨在让学生理解泛函中的基本概念和重要定理，并能运用已学知识证明泛函的命题", "泛函分析挺好学的，咦，我的头发呢0.0") },
        {74, new CourseInfo("代数几何", "介绍复几何的基本概念，定义和性质，包括复流形，全纯向量丛，Kahler流形的基本定义，介绍层论在代数几何中的基本应用", "这课真的好.............难顶啊") },
        {75, new CourseInfo("有限群表示论", "系统地介绍了近现代有限群表示论的基本研究对象和研究方法，为研究相关领域的本科生和研究生准备", "硬核选修课之一") },
        {76, new CourseInfo("数值分析", "研究数值分析的基本概念和理论，包括插值、数值逼近和曲线拟合、求解线性方程组的直接法和间接法、数值积分和矩阵特征值的求解方法", "应用性很强的一门专业课，推荐指数max") },
        {77, new CourseInfo("拓扑学", "介绍点集拓扑和代数拓扑的一般概念和具体例子，为后续的分析，几何（代数几何和微分几何）和更高的拓扑学课程奠定基础", "和拓扑相关的内容都不会简单的...") },
        {78, new CourseInfo("时间序列分析", "讲述时间序列里一系列重要的概念,是时间序列方法论与实践的结合,你将学习如何对一些时间序列数据进行建模，分析和预测并能阅读一些这方面的文献，同时磨炼做时间序列方面有关论文的能力", "统计系硬核必修课之一，外系学生慎选") },
        {79, new CourseInfo("多元统计分析", "研究在多个对象和多个指标互相关联的情况下如何分析它们的统计规律", "tips: 需要点亮技能点——SAS简单编程与分析") },

        //CourseInfo of EE
        {81, new CourseInfo("模拟电路", "一切电子电路的基础，学习对模拟信号进行传输、变换、处理、放大、测量和显示等工作的电路", "通信四大天书之一，学过的人都明白") },
        {82, new CourseInfo("数字电路", "电子系各专业的基础课，研究用数字信号完成对数字量进行算术运算和逻辑运算的电路", "通信四大天书之一，模拟电路的亲兄弟") },
        {83, new CourseInfo("固态电子学", "学习有关电子材料和电子器件的基础知识，包括材料科学的基本概念，分子动力学基础，晶体结构及缺陷，电导和热导，量子物理基础，现代物理理论基础，p-n 结的基本原理，发光器件的基本原理和结构等", "新兴前沿学科，推荐") },
        {84, new CourseInfo("信号与系统", "微电子科学与工程、通信工程、材料科学与工程的重要专业类课程之一，研究信号分析和系统分析的基本概念和基本分析方法", "电子系的代码课23333") },
        {85, new CourseInfo("通信原理", "介绍基本的模拟与数字通信技术，包括模拟幅度调制、模拟频率调制、模拟相位调制、基带和带通数字信号的传输，基本的信噪比分析等", "堪比计算机系的数据结构，硬就完事了") },
        {86, new CourseInfo("工程电磁场理论", "电气工程专业必修的一门专业基础课，主要介绍矢量分析，库伦定律和电场强度，电通量密度和高斯定律，能量和电位，导体、电介质和电容，恒定磁场与磁性材料，时变电磁场和麦克斯韦方程等", "通信四大天书之一，学的心累QAQ") },
        {87, new CourseInfo("半导体器件导论", "讲授半导体器件的基础物理知识，如载流子传输，双极性传输，非平衡过剩载流子，以及各种半导体器件如PN二极管，发光二极管，太阳能电池，MOS电容，场效应晶体管等", "对半导体器件感兴趣的同学不容错过") },
        {88, new CourseInfo("无线通信", "介绍无线通信系统的基本理论、技术问题、设计思路和分析方法，包括无线信道模型、无线信道容量、无线通信中的调制编码技术等", "通信原理进阶分支之一，硬不硬核心里没数嘛？") },
        {89, new CourseInfo("数字信号处理", "介绍数字信号处理的基本理论和知识，重点介绍离散时间信号和系统的z变换，傅里叶变换及其快速实现，滤波器设计，功率谱估计方法等", "信号处理的重要分支之一，支撑起现代通信设备的发展") },

        {91, new CourseInfo("数字图像处理", "研究图像处理的总体领域，旨在培养学生理解图像处理的基本算法和实现方式、尝试阅读图像处理的研究文献，并应用图像处理算法解决实际问题", "信号处理的重要分支之一，应用广泛") },
        {92, new CourseInfo("语音信号处理", "介绍语音信号处理的基础、原理、方法和应用", "信号处理的重要分支之一，发展迅速，应用前景很好") },
        {93, new CourseInfo("数字系统设计", "本课程介绍了一种用于对数字逻辑系统进行描述，仿真，综合，实现的硬件描述语言(HDL)，旨在培养学生通过大量的实验，使用电子设计自动化工具来设计和实现数字逻辑系统", "敲代码使人快乐（确信）") },
        {94, new CourseInfo("集成电路设计", "专注传授电源管理集成电路设计的相关原理和技巧", "侧重实践的专业必修课之一，推荐") },
        {95, new CourseInfo("光纤通信原理与技术", "本课程旨在培养学生将掌握光纤通信的基本原理和技术，了解光纤通信相关的各种器件。了解从光纤结构、光源、光功率发射与耦合、光检测接收到波分复用、光放大器以及非线性效应等知识", "和通信原理挂钩的课都不简单？试试才知道") },
        {96, new CourseInfo("非线性优化技术", "介绍非线性优化概念及其在电子及电气方向上的应用，以及现代建模和优化方法包括基于知识的方法比如替代模型及空间映射算法，全局优化算法如粒子群算法等", "应用性很强的专业选修课，推荐学习~") },
        {97, new CourseInfo("信息光学基础", "本课程讲述波动光学的基本概念，光波传播的物理规律和计算方法", "tips: 需要技能点——傅里叶变换") },
        {98, new CourseInfo("微波工程", "课程包括微波传输线和微波网络的基本理论介绍，并包括组成通信系统的基本器件，例如谐振器、功分器、耦合器、滤波器、放大器、混频器等", "硬核专业必修课之一，试问电子系哪门专业必修课不硬核呢") },
        {99, new CourseInfo("液晶光电子学", "从光的偏振出发，讲述液晶的基础知识，光在各向异性介质中的传播和散射，液晶连续体弹性形变理论，同时结合实验课程，学习液晶光电子器件的工艺加工、光电特性表征及性能测试", "动脑+动手，双倍的快乐") },
		
		//CourseInfo of Others
		{0, new CourseInfo("足球") },
        {10, new CourseInfo("篮球") },
        {20, new CourseInfo("排球") },
        {30, new CourseInfo("网球") },
        {40, new CourseInfo("游泳") },
        {50, new CourseInfo("西方音乐史", "介绍西方古典音乐发展的大致脉络，从古希腊音乐一直到二十世纪音乐，介绍并简单分析历史上著名的作曲家以及代表作，通过讲述搭配多媒体播放以及现场钢琴示范的方式让学生对西方古典音乐有一个完整的认识", "老师很和蔼，体验极好，推荐") },
        {60, new CourseInfo("空间中的美术史", "以“建筑”和“空间”切入美术史议题，侧重考察作为物质文化的视觉艺术在现实空间语境中的呈现和体现", "为数不多的硬核人文课，但是会让你受益良多") },
        {70, new CourseInfo("工笔花鸟", "以传统中国画的审美意识为出发点，培养学生了解与掌握工笔花鸟画传统的造型特点和技法基础，丰富学生的艺术文化知识，提高学生的艺术修养、审美鉴赏和创作能力", "大学里的美术课，找回曾经那种熟悉的感觉") },
        {80, new CourseInfo("科幻电影鉴赏", "通过对多部中外科幻电影作品的鉴赏分析，有选择地将科幻小说和相关电影的鉴赏和批评方法传达给学生", "偏硬核，但是好玩！") },

        {90, new CourseInfo("想象力入门", "从想象力的概念出发，讲述想象力的理论流变、想象力的心理生理机制、想象力的呈现以及想象力的教育危机与应对策略等", "Sustech thinks BIG!") },
        {100, new CourseInfo("人文讲座", "邀请国内人文学界知名学者，前来南科大做专题授课，旨在扩展同学的知识视野，领受国内一流人文学者的学术风采，并由此感受精彩的人文通识知识影响", "人文与科学相辅相成，二者缺一不可") },
        {110, new CourseInfo("教你唱歌", "教学生演唱表演具有地方特色的民歌小曲、创作型民歌、中国歌剧、西方歌剧、音乐剧等等，让学生感受歌唱带来的魅力", "“一路向南，追逐梦想的光亮，这是未来的主场，岁月听得见我们在歌唱……”") },
        {120, new CourseInfo("心理学", "介绍一系列关于大脑与心理如何运行的基本概念、原理及应用，包括感觉与知觉、注意、学习与记忆、动机与情绪、发展过程、语言习得、社会心理、能力、人格以及心理健康", "很有趣的选修课，推荐") },
        {130, new CourseInfo("人格塑造", "主要从生物遗传、社会经验与文化土壤等视角，介绍人格形成的过程与机制，以及健全人格塑造的路径和方法", "今天你塑造人格了吗？") },
        {140, new CourseInfo("诗词格律", "带领学生学习和鉴赏中国古诗词，增强民族文化自信，增强对祖国大好河山的热爱，陶冶情操，增强文学鉴赏能力，还可丰富知识，增强智慧", "诗词的魅力无穷无尽，快来领略一下吧") },
        {150, new CourseInfo("美术鉴赏", "选取中外美术发展史上有代表性的美术名作进行有分析有综合的讲授，对不同门类美术作品的特点、技法、构成因素、历史文化背景等进行介绍，并以作品的形式美感欣赏为主要内容，深入分析经典美术作品的艺术价值", "老师很有学问，课程体验很好，推荐") },
        {160, new CourseInfo("中文信息处理", "对中文信息处理学科做一个概况性的介绍，通过具体的实例分析，展示中文信息处理技术的基础原理，并介绍一些常用的工具和语料库", "需要编程的人文课，就问怕不怕？！（其实非常简单啦）") },
        {170, new CourseInfo("经典导读", "介绍《周易》、《论语》、《老子》、《坛经》的主要思想内容，了解这些经典在中国思想文化中的地位与价值，并由这些经典进一步了解中国古代的思想文化的整体及其历史发展", "小学期的人文课，又轻松又能学到东西，推荐") },
        {180, new CourseInfo("休闲文化", "介绍休闲的人本意义与社会价值、休闲文化的内涵及活动方式、休闲产业的特征与领域、休闲产业与体验经济、休闲与旅游产业、休闲与文化产业、休闲与娱乐产业、休闲与体育产业、休闲服务的人本基础", "学这么多东西，一点也不休闲23333") },
        {190, new CourseInfo("理解死亡", "围绕“死亡”这一议题而设计的社会科学通识选修课，试图将以下三个部分融为一体，即：对死亡的哲学思考；死亡命题所催生的文化表达、意义阐述；以及作为社会问题的死亡与临终", "老袁的招牌课，上过的都说好") },





    };
    void Start()
    {

    }

    public void update_info(int id)
    {
        try
        {
            text.text = courses[id].ToString();
        }
        catch
        {
            text.text = new CourseInfo("不知道什么课").ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
class CourseInfo
{
    private string name;
    private string content;
    private string eval;
    public CourseInfo(string name, string content = "手持两把锟斤拷，口中疾呼烫烫烫。", string eval = "咱也不知道，咱也不敢问，毕竟没选过")
    {
        this.name = name;
        this.content = content;
        this.eval = eval;
    }
    override
    public string ToString()
    {
        return "\n课程名：" + name + "\n\n课程内容：" + content + "\n\n课程评价：" + eval;
    }
}