// vue-router-ex-2 index.js
import Vue from 'vue'
import Router from 'vue-router'
Vue.use(Router)
// 1. 定义（路由）或导入组件
const Home = {
	template: `<div><p><img :src='img1' /></p></div>`,
	data() {
		return {
			img1: require('./images/ex-2-1-home.jpg'),
		}
	}
}
const Advantage = {
	template: `<div><p><img :src='img1' /></p></div>`,
	data() {
		return {
			img1: require('./images/ex-2-2-advantage.jpg'),
		}
	}
}
// 定义二级导航路由
const Product = {
	template: `<div>
	<p class="subrouter">
	<router-link class="r-link2" to = "/product/gaiyao" >概览</router-link>
	<router-link class="r-link2" to = "/product/sousuo" >搜索推广</router-link>
	<router-link class="r-link2" to = "/product/feed" >信息流推广</router-link>
	<router-link class="r-link2" to = "/product/juping" >聚屏推广</router-link>
	<router-link class="r-link2" to = "/product/kaiping" >开屏推广</router-link>
	<router-link class="r-link2" to = "/product/ivy"> 百青藤推广</router-link>
	</p>
	<router-view  > </router-view>
	</div >`
}
const Gaiyao = {
	template: `<div></div>`
}
const Sousuo = {
	template: ` <div class="container">	 
		  <div class="subrouter-left">
			<h1>什么是搜索推广</h1>
	  	<p>搜索推广是基于全球最大的中文搜索引擎百度搜索，在搜索结果显著的位置展示您的推广信息，只有客户点击广告之后，您才需要付费。</p>
			</div>
	    <div class="subrouter-right"><img :src="img1"/></div>
		</div>`,
	data() {
		return {
			img1: require('./images/ggsearch2.jpg')
		}
	}
}
const Feed = {
	template: `<div class="container">
	<div class="subrouter-left">
	<h1>什么是信息流推广</h1>
	<p>信息流推广是在百度APP、百度首页、贴吧、百度手机浏览器等平台的资讯流中穿插展现的原生广告，广告即是内容。</p>
</div>
<div class="subrouter-right"><img :src="img2"/></div>
</div>`,
	data() {
		return {
			img2: require('./images/infoFlow.jpg')
		}
	}
}
const Juping = {
	template: `<div class="container">
	<div class="subrouter-left">
	<h1>百度聚屏：</h1>
	<h1>程序化数字屏幕广告平台</h1>
  <p>百度聚屏通过聚合多类屏幕，触达消费者多场景生活时刻，实现线上线下广告整合和精准程序化投放。依托百度大数据及AI优势，百度聚屏致力于解决当前客户广告投放多种痛点，打造全新的品牌推广体验，为客户收入增长带来新的动力。</p>
</div>
 <div class="subrouter-right"><img :src="img3"/></div>
	</div>`,
	data() {
		return {
			img3: require('./images/screen.jpg')
		}
	}
}
const Kaiping = {
	template: `<div class="container">
	 <div class="subrouter-left">
	<h1>开屏是什么</h1>
	<p>百度开屏整合百度优质品牌广告流量，以APP开屏广告的样式进行强势品牌曝光</p>
	 </div>
	 <div class="subrouter-right"><img :src="img4"/></div>
	</div>`,
	data() {
		return {
			img4: require('./images/openScreen.jpg')
		}
	}
}
const Ivy = {
	template: `<div><img :src="img6"/></div>`,
	data() {
		return {
			img6: require('./images/baidubai.png')
		}
	}
}
const Case = {
	template: `<div><img :src="img3"/></div>`,
	data() {
		return {
			img3: require('./images/ex-2-4-case.jpg'),
		}
	}
}
const More = {
	template: `<div><img :src="img3"/></div>`,
	data() {
		return {
			img3: require('./images/ex-2-6-more.jpg'),
		}
	}
}
// 2. 定义路由,每个路由应该映射一个组件。 
const routes = [{
		path: '/home',
		component: Home,
		name: 'Home'
	},
	{
		path: '/advantage',
		name: 'Advantage',
		component: Advantage
	},
	{
		path: '/product',
		component: Product,
		//以下定义子路由
		children: [{ //默认的空子路由
				path: '',
				component: Gaiyao
			},
			{
				path: 'gaiyao',
				component: Gaiyao
			},
			{
				path: 'sousuo',
				component: Sousuo
			},
			{
				path: 'feed',
				component: Feed
			},
			{
				path: 'juping',
				component: Juping
			},
			{
				path: 'kaiping',
				component: Kaiping
			},
			{
				path: 'ivy',
				component: Ivy
			},
		]
	},
	{
		path: '/case',
		name: 'Case',
		component: Case
	},
	{
		path: '/help',
		name: 'More',
		component: More
	},
	{ //匹配不到路由时重定向到首页
		path: '/',
		redirect: '/home'
	}
]
// 3. 创建 router 实例，然后传 `routes` 配置
export default new Router({
	routes: routes,
	mode: 'history', //去掉URL中的#	
})

