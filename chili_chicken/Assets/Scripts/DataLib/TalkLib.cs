using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TalkLib{
    private Dictionary<string, List<string>> talkLibDict;
    private static TalkLib talkLib;
    private TalkLib() {
        talkLibDict = new Dictionary<string, List<string>>();
        talkLibDict.Add("Game1", new List<string> { "hello" });
        talkLibDict.Add("Teaching Building 1 1", new List<string> { "这里是一教，南科大教学的核心地点之一，各种各样的课程在这里开设。", "在这里你可以学习数学，金融以及电子的专业先修课程，请问你确定要开始一个学期的学习吗？" });
        talkLibDict.Add("Teaching Building 1 2", new List<string> { "这里是一教，南科大教学的核心地点之一，各种各样的课程在这里开设。", "在这里你可以学习计算机，数学，以及金融的专业先修课程，请问你确定要开始一个学期的学习吗？" });
        talkLibDict.Add("Liyuan1", new List<string> { "这里是荔园一栋，南科大的另一个核心教学地点，这里开设了很多硬核的课程等你学习", "在这里你可以学习计算机系的专业先修课和专业核心课，以及金融系的专业核心课\n请问你确定要开始一个学期的学习吗？" });
        talkLibDict.Add("X alice 1", new List<string> { "在说完这句话的时候，他已经爬到了坡顶", "面前是作为森林入口处的正门，门后便是她那伫立在月光下的洋房", "抬头看着洋房，少女觉得有些遗憾" });
        talkLibDict.Add("X alice 2", new List<string> { "我想象不出来那周围会是怎样的景象。", "不知是漫天飞舞的红叶，还是随风而起的蒲公英种子", "也许只是一个人逆着夕阳，衣裾随风作响，\n也许他看着一片暮色，流下两行清泪",
            "也许他已看不见，只听得耳边微悄风声，留下一抹令人心疼的微笑", "他就在一片暮色里，无声无息\n也许是孤独，也许是满足，满目却尽是苍然" });
        talkLibDict.Add("begin caiji", new List<string> {
            "一座巨大的校园\n坐落在深圳大学城的黄金地段\n这就是公立南方科技大学",
            "包括数学，物理，金融，计算机\n将对各个领域充满热情的一流高中生云集于此\n并加以培养\n是被寄予无限希望的教改先锋",
            "像我这样的菜鸡\n能在这样厉害的学校待下去吗？",
            "反正我能考上这里也只是靠运气而已\n总之，先进去吧",
            "全新的校园生活即将由此展开。。。\n这本应该是充满希望的一步才对，然而。。。",
            "出现在我眼前的是一片黑暗\n这就是修仙的开始\n也是健康作息的结束",
            "在这一刻我可能还没意识到\n我之所以能进入南方科技大学\n并不是因为什么超乎常人的幸运\n只是单纯的特别能肝才对",
            "欢迎来到南方科技大学"
        });
        talkLibDict.Add("Guide Wellcome", new List<string> { "你好呀，欢迎来到南科大\n我非常乐意为你服务", "这里是南科大的主校门，向左转可以到达教学区，直走可以到湖畔宿舍区\n至于再往里的地方，就留给你自己探索吧",
            "在南科大，你是非常自由的，你甚至可以在校园里快乐跑酷\n当然啦，不参与学习的话是无法推进进程的哟", "你说怎么学习？\n在这里，你需要通过类似打麻将的形式来度过每一个学期\n放心啦，这是我自己创造的世界，我是不会骗你的\n看你疑惑的眼神，还有什么问题吗\n乐意为你解答"
        });
        talkLibDict.Add("Kibo no hana", new List<string>
        {
            "总感觉南科大好安静呢，自习室里也没有肝代码的人，和去年期末真实天差地别啊",
            "是啊，可能是大家都已经变秃变强了吧",
            "不过这也和退学在家的我没关系了~",
            "看你那高兴的样子",

            "那是当然的了！大家作业都写完了，菜鸡们也在努力着，我也是加把劲骑士了呢" ,
            "啊。没错，我们至今为止所做的一切，并非全部木大，只要我们不不停下来，道路就会不断延伸",

            "砰砰砰" ,
            "大佬，你在干什么呀大佬" ,
            "哼，呃，啊啊啊啊啊啊啊啊啊啊啊啊♂！" ,
            "什么嘛，我debug还蛮厉害的嘛",

            "大。。。大佬" ,
            "为什么发出弱者的声音，ride on！（music on: kibo no hana~" ,
            "因为，因为——！",

            "我可是，南科大学子，夜晚的守望者金先生啊，爆个肝算不了什么" ,
            "怎么会，你竟然为了我这种菜鸡" ,
            "保护菜鸡就是我的工作",

            "但是！！" ,
            "好了，快走，被窝在。。。等着你" ,
            "而且，前辈，我终于明白了，我们根本不用停下来，只要不断前进就行了，只要不停下来，道路就会不断延伸"

        });
        

        talkLibDict.Add("练胆，树仁屋顶的油桶", new List<string>
        {
            "怎么办呢？怎么办呢？",
            "这里好高，好可怕呀",
            "？你要帮我下去吗？\n真实个热心肠的好人呢",
            "不过不用麻烦啦，我要在这里学会克服恐惧呢\n总有一天，我要能够自己独当一面",
            "你一定也有这样的想法吧\n南科大的同学们可不会轻易屈服哟",
            "我们一起努力吧，即使是一个油桶，也有要坚持的理想哦"
        });
        talkLibDict.Add("校名石", new List<string>
        {
            "校名石上工整地写着南方科技大学六个字\n虽然看上去非常新，但笔触却很厚重\n给人一种沉稳安心的感觉"
        });
        talkLibDict.Add("湖底之伞", new List<string>
        {
            "呀哈哈，被你发现啦？",
            "真没想到会有人到这种地方\n一般人谁没事会跳湖玩呀",
            "怕不是那个家伙说漏嘴了。。。\n不过反正也没关系啦，你是我来这里以后第一个见到的人，我很高兴哟。",
            "？你问我为什么会在这里？说来话长啊。。。" ,
            "被风吹过来的",
            "别，别激动，开个玩笑。。。",
            "不过我倒是很喜欢这个地方\n从水底透过虚幻的湖面看整个世界，有一种莫名的诗意。",
            "从出生以来，我一直以为世界就是我看到的那个样子\n" +
            "一成不变，无聊的沙滩",
            "直到那阵风把我带到了这里，我才发现了新世界。",
            "其实我很羡慕你们人类\n能够随意行动，探索这个世界。",
            "等你离开学校以后，如果发现什么有趣的故事\n记得到时候回来讲给我听呀，我会在这里等着你的",
            "和湖底之伞探讨哲学，情商增加了5点"
        }
        );
        talkLibDict.Add("湖底之伞_after", new List<string>
        {
            "呀哈哈，今天也是元气满满的一天呢\n会不会有什么冒险在等着我们呢？",
            ""
        });


        talkLibDict.Add("大榕树", new List<string>
        {
            "吼吼吼，又有年轻人来了呢\n没想到我一把老骨头，现如今还能重获新生啊",
            "多亏了你们，我才能看到这样的奇迹呀\n我已经老了，也干不了什么了，只能默默祝福你们",
            "请记住，没有任何奇迹是祈祷来的\n我不是什么神树，只是和你一样普通的生命",
            "也许我们所度过的每个平凡的日常，就是连续发生的奇迹啊"
        });
        talkLibDict.Add("HuiYuanYHH", new List<string> {

            "呀哈哈，被你发现了！",
            "慧园车站这个地点，果然还是挺明显的嘛",
            "既然叫慧园，就给你些奖励，让你变聪明些吧！",
            "（和慧园石头下的呀哈哈谈论哲学，智商+5）"

        });


        talkLibDict.Add("HuiYuanYHH_after", new List<string> {

            "我已经没什么新的哲学内容可以教授你了，剩下的需要你自己研究啦"

                });




        talkLibDict.Add("YiJiaoYHH", new List<string> {
            "呀哈哈，被你发现了！\n我是科格洛们的老师，教书之余喜欢在楼顶吹风。",
            "话说你是怎么上来的？这孩子呀，真是淘气",
        "莫非，你是跋山涉水前来向老夫求学的么？",
            "孺子可教也，既然如此，就给你些奖励，提高一些GPA吧！",
        "话说你要是已经满绩了，我就帮不了你啦。\n你的GPA提升了0.01"
         });


        talkLibDict.Add("YiJiaoYHH_after", new List<string> {

            "我要一个人清净一会儿，你走罢。",

                });


        talkLibDict.Add("YiHaoMenYHH", new List<string> {
            "呀哈哈，被你发现了！",
            "你也在这里等车?哈哈好巧呀。\n我刚从塘朗城吃完M记。我也不知道为什么大家要管它叫M记，我一般自己管它叫金拱门。",
            "做学生嘛，不要太肝，重要的是快乐！\n我看你好肝啊，头发都变少了，这样下去可不行",
            "既然这么有缘分，就给你些礼物吧!\n霸王防脱洗发水！",
        "祝你有个漂亮的发型。",
            "（获得霸王洗发水,发量-5）",
         "（-5 ? ? ? ?）"
                });


        talkLibDict.Add("YiHaoMenYHH_after", new List<string> {
            "对不起，我好像给错了。。"
                });



        talkLibDict.Add("XinYuanYHH", new List<string> {
            "呀哈哈，被你发现了！",
        "我是这个游戏的作者的朋友。",
            "偷偷告诉你，这个游戏的作者们就是在这里做的这个游戏哦",
            "既然你跑了这么远，总不能让你白来嘛，我可以让你变得更强哦！",
        "（你感觉你变秃了，也变强了，全能力+2，发量-10。。。）"
                });
        talkLibDict.Add("XinYuanYHH_after", new List<string> {
        "下学期，一起来肝projct呀~~~"
             });


        talkLibDict.Add("JiaoshiGongyuYHH", new List<string> {
            "呀哈哈，被你发现了！",
            "作为克洛格们的老师，我当然也住在教师公寓哦。",
        "哦。。不是这些大楼。\n这一堆石头才是我们克罗格的教师公寓.....",
        "这待遇的差距是真的大啊......",
        "不过没关心，我们不太在乎这个",
            "话说回来，我感觉你很有潜质，要不要参加我的联培的项目啊？可以提前毕业哦！",
        "（学期数+1）"
                });


        talkLibDict.Add("JiaoshiGongyuYHH_after", new List<string> {
            "联培项目只能给一个，我剩下的名额可是要留给下一局的玩家的！",
            });


        talkLibDict.Add("HuPanYHH", new List<string> {
            "呀哈哈，被你发现了！",
            "看来现在的学生们都喜欢登高啊。\n我一般失恋了，或者考砸了，都会来这里。\n顺便说一句，前几年我还是去的行政楼呢。可惜那个楼现在没了呢。",
            "既然发现了这个好地方，就收下这个礼物吧，我可以帮助你提高GPA哦。\n对了，我的老师也喜欢在楼顶看风景，不过他不像我喜欢宅在公寓。",
        "（GPA+0.01）"
                });
        talkLibDict.Add("HuPanYHH_after", new List<string> {

        "等下次考砸了，和我一起来这个天台呀~~"
        });



        talkLibDict.Add("ErQiYHH", new List<string> {
            "呀哈哈，被你发现了！",
            "我的宿舍真是小呢。给女生的宿舍怎么能这么小？行李都放不下了！\n不过也还行吧，食堂还不错。",
            "作为新生，可能给不了学长什么好的东西。\n但是，能和学长聊天，真的很开心。",
        "（你感觉你的情商变高了，情商+5）"
                });
        talkLibDict.Add("ErQiYHH_after", new List<string> {
        "有时间一起学习呀~~虽然是克洛格，但是课程还是一样的。"
        });
        talkLibDict.Add("希望的计网project", new List<string>
        {
            "总感觉计系好安静呢，机房里也没有肝dns的人，和去年期末真实天差地别啊",
            "是啊，可能是大家都已经叛逃去做sdn了吧",

            "不过这也和摸鱼等大佬出结果的我没关系了～",

            "看你那高兴的样子",


            "那是当然的了！大家sdn都写完了，大佬们也在肝着dns，我也是今天也没干劲骑士了呢",


            "啊。没错，我们至今所做的一切，并非完全白给，只要我们不停下来，道路就会不断延伸",


            "砰砰砰",


            "服务器你在干什么啊服务器",


            "哼，呃，啊啊啊啊啊啊啊啊啊啊啊啊！",


            "什么嘛，我复读还蛮厉害的嘛",


            "服。。。服务器",


            "为什么发出ping不通的声音，cast off！",


            "因为，因为——",


            "我可是，计算机系的学子，绝对不摸鱼的秦先生啊，做个project算不了什么",


            "怎么会，你竟然为了我这种狗头人",
            
            "拦截狗头人就是我的工作",
            "但是！！",
            "好了，快走，挂科在。。。等着你",


            "而且，我终于明白了，我们根本不需要停下来，只要不断停下来，道路就会不断延伸，你也一定会崩溃的啊！",
            
            "你，到底想说什么",
            
            "我不做复读机了！jojo!"
        });
        talkLibDict.Add("无线通信", new List<string>
        {
            "我接下来要说的事，你千万不要害怕" ,
            "我刚才，USRP跑写好的代码跑了四个小时才出结果" ,
            "你问USRP是哪一位？\n不是哪一位是无线通信用的USRP",
            "（向对方展示手机）",
            "啊它不是主机是中间节点",
            "（向对方展示路由器）",
            "不，它不是三层设备是二层设备",
            "（向对方展示集线器）",
            "软件呢？这玩意儿怎么跑程序？",
            "（向对方展示交换机）" ,
            "这.......",
            "（路过的大佬抢过画改成了三层交换机）",
            "USRP啊！通信原理学过没有？就是那种美国进口的，功能很强的，那种一台好几万的USRP，明白吗？",
            "它疯狂出bug，让我怀疑我程序有问题，这怎么可能啊？然后我改了参数，它就开始卡我，不过是capture time长了一点，卡到我电脑六个核全都炸了！",
            "它结果一出来，是误判，误判！卡了我这么久，packet完全没找到，还不是得重来，然后我就改了参数，duang的一下结果就出来了，你猜怎么着？没收到！",
            "我就在那儿等了四个小时，中间一不小心没注意错过了好几次正确的结果，才终于得到了正确的结果........",
            "（对方讲得入神，没有注意到这边，憋着笑悄悄溜了）"

        });
        talkLibDict.Add("卡面来打", new List<string>
        {
            "已经第五天了，DNS的任务书，为什么只是看着而已呢\n明明知道不去做的话就什么也改变不了，那为什么只是看着而已呢" ,
            "难道我，真的背叛了吗（拿出铅笔）" ,
            "（虽然铅笔并没有说话，但是不可思议地理解了铅笔的意思\n好像是在说，和我签订契约，成为SDN魔法少女吧）" ,
            "它说，可以上了\n那么，答案就只有一个了！" ,
            "再见了DNS，还有我的懦弱！" ,
            "我将为SDN献上忠诚！（折断铅笔）"
        });
        talkLibDict.Add("WAWA大哭", new List<string>
        {
            "你们这个系统是干嘛来的？干嘛拉我进这个系统啊",
            "搞得我三更半夜都睡不了觉，影响了白天的上课",
            "你们这是个什么系统啊，你们搞这个系统害人不浅啊",
            "我的代码跑出来每次都是WA呐，好不容易没WA还是个TLE啊",
            "现在才大二，你叫我怎么办啊？我现在还没进系啊好不好？",
            "你们这是个什么系统啊？\n你们这是想让我死啊！",
            "谁是TA？快点出来你这个TA！再不出来我退学了啊！",
            "我跟你们说你们这些人啊，一、一天到晚啊，搞这些什么代码啊，OJ啊，会害死你们的，你们这样没有头发的我跟你们说",
            "你们这四百多个人，好好养生不好吗？一天到晚都在写代码，有什么意思，有什么意思啊？",
            "麻烦你们重视一下你们的猝死概率好不好？有一点睡眠时间好不好？一天到晚写代码是不是人啊？",
            "（由于对方情绪激动，已被移出群聊）"
        });
        talkLibDict.Add("鸽子", new List<string>
        {
            "明明是我先来的，为什么会变成这样呢？睡一觉的也好，堵车的也好，40分钟了，为什么连消息都没有收到呢？",
            "为什么会变成这样呢，第一次找到了一起做的队友，也找到了更好做的课题，两件快乐的事重合在一起，而这两份快乐，又给我带来更多的快乐。得到的，本应是梦境一般欢快的时间......但是，为什么，会变成这样呢.....",
            "为什么你们鸽得这么熟练啊！你们到底鸽过多少次啊！你们到底要把咕咕咕的声音刻进我DNA里多深才甘心啊？" ,
            "Project什么的，已经无所谓了，因为已经不再有人，会来一起做了。传达不到的队友，已经不需要了，要问为什么的话，因为——我也鸽了！"
        });
        talkLibDict.Add("希望的象征", new List<string>
        {
            "嗯？你问我为什么在这里？\n当然是好玩啦，随处走走",
            "你说他们呀",
            "都是期末project写自闭了的南科大学生啦\n南科大的学习很休闲的",
            "你觉得看起来很可怕？",
            "没有没有，他们可都是希望的象征啊",
            "只有在最深邃的黑暗中，才能诞生出最璀璨的希望啊",
            "看着学长迷狂的眼神，你感到有点害怕，溜了溜了"
        });



    }
    public static TalkLib GetTalkLib(){
        if(talkLib == null){
            talkLib = new TalkLib();
        }
        return talkLib;

    }
    public List<string> GetTalkContent(string key){
        if(talkLibDict.ContainsKey(key)){
            return talkLibDict[key];
        }
        else{
            return null;
        }
    }

    


}