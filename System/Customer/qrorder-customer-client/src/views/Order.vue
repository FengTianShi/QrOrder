<template>
  <div id="layout">
    <div id="header">
      <MainHeader />
    </div>

    <div id="content">
      <div id="side">
        <FoodMenu />
      </div>

      <div id="main" class="container-fluid">
        <div class="row">
          <div class="col px-1 pt-0 pb-0">
            <p class="h5">お寿司</p>
          </div>
        </div>

        <div
          class="row row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-lg-4 row-cols-xl-5 row-cols-xxl-6">
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
        </div>

        <div class="row">
          <div class="col px-1 pt-4 pb-0">
            <p class="h5">おつまみ</p>
          </div>
        </div>

        <div
          class="row row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-lg-4 row-cols-xl-5 row-cols-xxl-6">
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
          <div class="col p-1">
            <FoodCard class="" />
          </div>
        </div>
      </div>

      <div class="fixed-bottom">
        <div class="d-grid">
          <button
            type="button"
            class="btn btn-danger rounded-pill m-2"
            data-bs-toggle="modal"
            data-bs-target="#cartModal">
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

  <FoodModal />
  <CartModal />
  <RestaurantModal />
</template>

<script>
import MainHeader from "@/components/MainHeader.vue";
import FoodMenu from "@/components/FoodMenu.vue";
import FoodCard from "@/components/FoodCard.vue";
import FoodModal from "@/components/FoodModal.vue";
import CartModal from "@/components/CartModal.vue";
import RestaurantModal from "@/components/RestaurantModal.vue";

export default {
  components: {
    MainHeader,
    FoodMenu,
    FoodCard,
    FoodModal,
    CartModal,
    RestaurantModal,
  },
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
  padding-bottom: 114px;
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
