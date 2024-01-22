<template>
  <div>
    <button
      class="navbar-toggler"
      type="button"
      data-bs-toggle="offcanvas"
      data-bs-target="#offcanvasNavbar">
      <span class="navbar-toggler-icon"></span>
    </button>

    <div
      class="offcanvas offcanvas-top rounded-bottom-2"
      tabindex="-1"
      id="offcanvasNavbar"
      style="height: 260px">
      <div
        class="offcanvas-header py-2"
        style="padding-left: 12px; padding-right: 28px">
        <Brand />
        <button
          type="button"
          class="btn-close"
          data-bs-dismiss="offcanvas"
          aria-label="Close"></button>
      </div>
      <div class="offcanvas-body">
        <div class="list-group list-group-flush">
          <button
            type="button"
            class="list-group-item list-group-item-action border-0 rounded-2 p-2">
            <i class="bi bi-shop me-2" /> 店舗情報
          </button>
          <button
            type="button"
            class="list-group-item list-group-item-action border-0 rounded-2 p-2">
            <i class="bi bi-bell me-2" /> 店員呼び出し
          </button>
          <button
            type="button"
            class="list-group-item list-group-item-action border-0 rounded-2 p-2">
            <i class="bi bi-clock-history me-2" /> 注文歴史
          </button>

          <!-- PayPal, Credit Card ... -->
          <button
            type="button"
            class="list-group-item list-group-item-action border-0 rounded-2 p-2">
            <i class="bi bi-credit-card me-2" /> お会計
          </button>

          <!-- <button
            type="button"
            class="list-group-item list-group-item-action border-0 rounded-2 p-2">
            システム言語
          </button>
          <button
            type="button"
            class="list-group-item list-group-item-action border-0 rounded-2 p-2">
            メニュー言語
          </button>
          <button
            type="button"
            class="list-group-item list-group-item-action border-0 rounded-2 p-2">
            Food検索
          </button> -->
        </div>
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
