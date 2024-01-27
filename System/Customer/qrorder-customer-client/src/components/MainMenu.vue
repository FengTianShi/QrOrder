<template>
  <button
    type="button"
    class="navbar-toggler"
    data-bs-toggle="offcanvas"
    data-bs-target="#offcanvasNavbar">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div
    class="offcanvas offcanvas-top rounded-bottom-2"
    tabindex="-1"
    id="offcanvasNavbar"
    style="height: 420px">
    <div class="container-fluid">
      <div class="row px-1">
        <div class="col-9 p-0">
          <div class="navbar">
            <Brand />
          </div>
        </div>
        <div class="col-3 offcanvas-header flex-row-reverse">
          <button type="button" class="btn-close" data-bs-dismiss="offcanvas" />
        </div>
      </div>
    </div>

    <div class="offcanvas-body">
      <form class="d-flex mb-2">
        <input class="form-control me-2" type="search" placeholder="商品名" />
        <button
          class="btn btn-outline-success"
          type="submit"
          style="white-space: nowrap">
          検索
        </button>
      </form>

      <div class="dropdown mb-2">
        <button
          class="btn btn-light dropdown-toggle text-start w-100"
          type="button"
          data-bs-toggle="dropdown">
          <i class="bi bi-bell-fill me-2" /> サービス
        </button>
        <ul class="dropdown-menu dropdown-menu-end">
          <li><a class="dropdown-item" href="#">店員呼び出し</a></li>
          <li><a class="dropdown-item" href="#">お水</a></li>
        </ul>
      </div>

      <div class="dropdown mb-2">
        <button
          class="btn btn-light dropdown-toggle text-start w-100"
          type="button"
          data-bs-toggle="dropdown">
          <i class="bi bi-translate me-2" /> メニュー言語
        </button>
        <ul class="dropdown-menu dropdown-menu-end">
          <li><a class="dropdown-item" href="#">日本語</a></li>
          <li><a class="dropdown-item" href="#">English</a></li>
        </ul>
      </div>

      <div class="dropdown mb-2">
        <button
          class="btn btn-light dropdown-toggle text-start w-100"
          type="button"
          data-bs-toggle="dropdown">
          <i class="bi bi-translate me-2" /> アプリ言語
        </button>
        <ul class="dropdown-menu dropdown-menu-end">
          <li><a class="dropdown-item" href="#">日本語</a></li>
          <li><a class="dropdown-item" href="#">English</a></li>
        </ul>
      </div>

      <div class="list-group list-group-flush">
        <button
          type="button"
          class="list-group-item list-group-item-action border-0 rounded-2 p-2">
          <i class="bi bi-shop me-2" /> 店舗情報
        </button>

        <button
          type="button"
          class="list-group-item list-group-item-action border-0 rounded-2 p-2">
          <i class="bi bi-clock-history me-2" /> 注文歴史
        </button>

        <!-- Credit Card, PayPal ... -->
        <button
          type="button"
          class="list-group-item list-group-item-action border-0 rounded-2 p-2">
          <i class="bi bi-credit-card me-2" /> お会計
        </button>
      </div>
    </div>
  </div>
</template>

<script>
import Brand from "@/components/Brand.vue";

export default {
  components: { Brand },
};
</script>

<style scoped></style>
