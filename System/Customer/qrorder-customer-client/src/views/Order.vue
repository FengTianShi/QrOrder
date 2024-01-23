<template>
  <div id="layout">
    <div id="header">
      <Header />
    </div>

    <div id="content">
      <div id="side">
        <FoodMenu />
      </div>

      <div id="main">
        <div class="d-flex flex-wrap justify-content-center">
          <FoodCard />
          <FoodCard />
          <FoodCard />
          <FoodCard />
          <FoodCard />
          <FoodCard />
          <FoodCard />
          <FoodCard />
          <FoodCard />
          <FoodCard />
        </div>
      </div>

      <div class="fixed-bottom">
        <div class="d-grid">
          <button
            type="button"
            class="btn btn-danger rounded-pill m-2"
            data-bs-toggle="modal"
            data-bs-target="#cart">
            <i class="bi bi-cart4 me-1" style="font-size: 18px" />
            <span class="me-1">カート</span>
            <span class="badge bg-warning border border-light rounded-circle">
              4
            </span>
          </button>
        </div>
      </div>
    </div>
  </div>

  <Food />
  <Cart />
  <Restaurant />
</template>

<script>
import Header from "@/components/Header.vue";

import FoodMenu from "@/components/FoodMenu.vue";
import FoodCard from "@/components/FoodCard.vue";

import Food from "@/components/Food.vue";
import Cart from "@/components/Cart.vue";
import Restaurant from "@/components/Restaurant.vue";

export default {
  components: { Header, FoodMenu, FoodCard, Food, Cart, Restaurant },
};
</script>

<style>
body {
  margin: 0px;
  padding: 0px;
}

#layout {
  width: 100%;
  height: 100%;
  position: fixed;
}

#header {
  width: 100%;
  height: 56px;
  float: left;
}

#content {
  width: 100%;
  height: 100%;
  float: left;
  display: flex;
  padding-bottom: 120px;
}

#side {
  width: 150px;
  height: 100%;
  overflow-y: auto;
}

#main {
  width: 100%;
  height: 100%;
  overflow-y: auto;
}
</style>
