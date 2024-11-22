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
const Advantage = {}
const Product = {
	template: `<div>
	<p class="subrouter">
	<router-link class="r-link2" to = "/product/gaiyao" >概览</router-link>
	</p>
	<router-view  > </router-view>
	</div >`
}
const Gaiyao = {}
const Sousuo = {
	
	// <h1>什么是搜索推广</h1>
	// <p>搜索推广是基于全球最大的中文搜索引擎百度搜索，在搜索结果显著的位置展示您的推广信息，只有客户点击广告之后，您才需要付费。</p>
	
}
const Feed = {
	// <h1>什么是信息流推广</h1>
	// 	<p>信息流推广是在百度APP、百度首页、贴吧、百度手机浏览器等平台的资讯流中穿插展现的原生广告，广告即是内容。</p>
	
}
const Juping = {
	// <h1>百度聚屏：</h1>
	// 	<h1>程序化数字屏幕广告平台</h1>
	//   <p>百度聚屏通过聚合多类屏幕，触达消费者多场景生活时刻，实现线上线下广告整合和精准程序化投放。依托百度大数据及AI优势，百度聚屏致力于解决当前客户广告投放多种痛点，打造全新的品牌推广体验，为客户收入增长带来新的动力。</p>
	
}
const Kaiping = {
	// <h1>开屏是什么</h1>
	// <p>百度开屏整合百度优质品牌广告流量，以APP开屏广告的样式进行强势品牌曝光</p>
	
}
const Ivy = {}
const Case = {}
const More = {
	template: `<div></div>`,	
}
// 2. 定义路由,每个路由应该映射一个组件。 
const routes = [{
		path: '/home',
		component: Home,
		name: 'Home'
	},
	
]
// 3. 创建 router 实例，然后传 `routes` 配置
export default new Router({
	routes: routes,
	mode: 'history', //去掉URL中的#	
})

