<!-- vue-router-ex-2 App.vue -->
<template>
	<div id="app" class="div1">
		<p class="p1">
			<!-- 使用 router-link 组件来导航. 通过传入to属性指定链接-->
			<router-link to="/home" class="r-link1">首页</router-link>
			<!-- 跳转到外部URL时，使用a标记 -->
			<a href="http://e.baidu.com/gongyi/index.html" target="_blank" class="r-link1">公益推广</a>
			<a href="tel: 4008008888">400-800-8888 </a><a><span>免费注册</span></a>
		</p>
		<div class="r-view">
			<router-view class="r-view"></router-view>
		</div>
		<div class="footer">
			<p>&copy;<a href="http://e.baidu.com/accept.htm" target="_blank">Baidu使用百度前必读
				</a> 国家药监局：（京）-经营性-2012-0009</p>
		</div>

	</div>
</template>

<script>
	export default {
		name: 'App',
	}
</script>

<style>
	#app {
		text-align: center;
		color: #2c3e50;
		margin-top: 60px
	}

	.r-view {
		margin: 0 auto;
		text-indent: 2em;
		text-align: left;
		padding: 5px 0;

	}

	.r-view img {
		width: 1440px;
		height: 533px;
	}

	.r-link1 {}

	.r-link2 {}

	.r-link1:hover {
		border-bottom: 2px solid black;padding: 10px 5;
	}


	.p1 {
		background: url(router/images/baidu.png) no-repeat 80px center;
	}

	p img {
		vertical-align: bottom;
	}

	a span {
		background-color: #0000CC;
		color: white;
		padding: 10px 25px;
		margin-left: 20px;
	}

	.subrouter {
		background-color: #DADADA;
		padding: 15px 150px;
	}

	.subrouter-left {
		/* 	display: inline-block; */
		float: left;
		width: 530px;
		height: 325px;
		margin: 0px 20px;

	}

	.subrouter-right {
		/* display: inline-block; */
		float: left;
		width: 530px;
		height: 325px;
		margin: 0px 20px;

	}

	.subrouter-right img {
		width: 500px;
		height: 300px;
		padding: 0px;
		margin: 0px;
	}

	.container {
		padding: 30px 50px;
	}

	.footer {
		clear: both;
		margin: 20px auto;
	}
</style>
